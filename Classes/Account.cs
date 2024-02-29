using BTS_Mitarbeiterverwaltung.Classes;
using BTS_Mitarbeiterverwaltung.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

internal class Account
{
    public static void CreateUser(string username, string password, string confirmPassword)
    {
        try
        {
            if (DoUsernameExist(username))
            {
                throw new Exception("Benutzername bereits vergeben.");
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))   // Überprüfen, ob Benutzername und Passwort gültig sind (z. B. nicht leer)
            {
                throw new Exception("Benutzername und Passwort dürfen nicht leer sein.");
            }

            if (password != confirmPassword)     // Überprüfen, ob Passwort und Passwortbestätigung übereinstimmen
            {
                throw new Exception("Passwort und Passwortbestätigung stimmen nicht überein. Bitte überprüfen Sie Ihr Passwort!");
            }

            if (password.Contains(" "))          // Überprüfen, ob das Passwort Leerzeichen enthält
            {
                throw new Exception("Das Passwort darf keine Leerzeichen enthalten.");
            }

            // Verhindere die Verwendung von Benutzerinformationen im Passwort
            if (password.ToLower().Contains(username.ToLower()))
            {
                throw new Exception("Das Passwort darf keine Benutzerinformationen enthalten.");
            }

            // Überprüfen, ob das Passwort sicher genug ist (z.B. Mindestlänge, enthält Buchstaben und Zahlen)
            string errorMessage;
            if (!IsPasswordSafe(password, out errorMessage))
            {
                throw new Exception($"Das Passwort erfüllt nicht die Sicherheitsanforderungen. \n{errorMessage}");
            }


            string salt = PasswortUtility.GeneriereZufaelligesSalt();           // Generiere zufälliges Salt

            string insertQuery = "INSERT INTO Benutzer (Benutzername, PasswortHash, Salt) VALUES (@Benutzername, @PasswortHash, @Salt)";

            using (SqlCommand command = new SqlCommand(insertQuery, SqlVariable.connection))
            {
                command.Parameters.AddWithValue("@Benutzername", username);     // Setze Parameter für Benutzername, PasswortHash und Salt
                command.Parameters.AddWithValue("@PasswortHash", PasswortUtility.HashPasswort(password, salt));
                command.Parameters.AddWithValue("@Salt", salt);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Benutzer wurde erfolgreich erstellt!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            if (SqlVariable.connection.State == ConnectionState.Open)
            {
                SqlVariable.connection.Close();
            }
        }
    }

    private static bool IsPasswordSafe(string password, out string errorMessage)
    {
        errorMessage = null;

        if (password.Length < 6)
        {
            errorMessage = "Das Passwort muss mindestens 6 Zeichen lang sein.";
            return false;
        }

        if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit)) // Prüfe, ob Passwort mind. ein Buchstaben + Zahl enthält
        {
            errorMessage = "Das Passwort muss mindestens einen Buchstaben und eine Zahl enthalten.";
            return false;
        }

        if (!password.Any(IsSpecialCharacter))    // Prüfe, ob das Passwort mind. ein Sonderzeichen enthält
        {
            errorMessage = "Das Passwort muss mindestens ein Sonderzeichen enthalten.";
            return false;
        }

        errorMessage = null;         //Passwort erfüllt alle Sicherheitsanforderungen
        return true;
    }

    private static bool IsSpecialCharacter(char c)
    {
        return "!@#$%^&*()-_=+[]{}|;:'\"<>,.?/~`".Contains(c);
    }

    public static bool DoUsernameExist(string benutzername)
    {
        string query = "SELECT COUNT(*) FROM Benutzer WHERE Benutzername = @Benutzername";

        using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
        {
            command.Parameters.AddWithValue("@Benutzername", benutzername);

            int benutzerCount = (int)command.ExecuteScalar();

            return benutzerCount > 0;
        }
    }

    public static bool Validation(string benutzername, string passwort)
    {
        try
        {
            string query = "SELECT Benutzername, PasswortHash, Salt FROM Benutzer WHERE Benutzername = @Benutzername";

            using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
            {
                command.Parameters.AddWithValue("@Benutzername", benutzername);

                if (SqlVariable.connection.State != ConnectionState.Open)
                {
                    SqlVariable.connection.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPasswortHash = reader["PasswortHash"].ToString();     // Benutzer gefunden, überprüfe das Passwort
                        string salt = reader["Salt"].ToString();

                        // Verwende HashPasswort-Methode aus der PasswortUtility
                        string inputPasswortHash = PasswortUtility.HashPasswort(passwort, salt);

                        return storedPasswortHash == inputPasswortHash;
                    }
                }
            }
            return false;   // Benutzername nicht gefunden
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Überprüfen des Logins: {ex.Message}");
            return false;
        }
        finally
        {
            if (SqlVariable.connection.State == ConnectionState.Open)
            {
                SqlVariable.connection.Close();
            }
        }
    }
}
