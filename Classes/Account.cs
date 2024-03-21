using BTS_Mitarbeiterverwaltung.Classes;
using BTS_Mitarbeiterverwaltung.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

internal class Account
{
    // Erstellt einen neuen Benutzer mit den angegebenen Anmeldeinformationen.
    // Parameter:
    //   username: Der Benutzername des neuen Benutzers.
    //   password: Das Passwort des neuen Benutzers.
    //   confirmPassword: Die Bestätigung des Passworts.
    // Ausnahmen:
    //   Exception: Wird ausgelöst, wenn bereits ein Benutzer mit dem angegebenen Benutzernamen existiert.
    //   Exception: Wird ausgelöst, wenn der Benutzername oder das Passwort leer sind.
    //   Exception: Wird ausgelöst, wenn das Passwort und die Passwortbestätigung nicht übereinstimmen.
    //   Exception: Wird ausgelöst, wenn das Passwort Leerzeichen enthält.
    //   Exception: Wird ausgelöst, wenn das Passwort dem Benutzernamen ähnelt.
    //   Exception: Wird ausgelöst, wenn das Passwort die Sicherheitsanforderungen nicht erfüllt.
    //   Exception: Wird ausgelöst, wenn ein Fehler beim Erstellen des Benutzers auftritt.
    internal static void CreateUser(string username, string password, string confirmPassword)
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

            // Passwort ähnlich dem Benutzernamen gibt Fehlermeldung aus (leicht erratbares Passwort)
            if (password.ToLower().Contains(username.ToLower()))
            {
                throw new Exception("Das Passwort darf keine Benutzerinformationen enthalten.");
            }

            // Überprüfen, ob das Passwort sicher genug ist (z.B. Mindestlänge, enthält Buchstaben und Zahlen)
            string errorMessage;
            if (!CheckPassword(password, out errorMessage))
            {
                throw new Exception($"Dein Passwort erfüllt nicht die Sicherheitsanforderungen. \n{errorMessage}");
            }


            string salt = PasswortUtility.GenerateRandomSalt();     

            string insertQuery = "INSERT INTO Benutzer (Benutzername, PasswortHash, Salt) VALUES (@Benutzername, @PasswortHash, @Salt)";

            using (SqlCommand command = new SqlCommand(insertQuery, SqlVariable.connection))
            {
                // Setze Parameter für Benutzername, PasswortHash und Salt
                command.Parameters.AddWithValue("@Benutzername", username);    
                command.Parameters.AddWithValue("@PasswortHash", PasswortUtility.HashPassword(password, salt));
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

    // Überprüft die Gültigkeit eines Passworts anhand verschiedener Sicherheitskriterien.
    // Parameter:
    //   password: Das zu überprüfende Passwort.
    //   errorMessage: Die Fehlermeldung, die eine ungültige Bedingung beschreibt (Rückgabewert).
    // Rückgabewert:
    //   True, wenn das Passwort die Sicherheitsanforderungen erfüllt, andernfalls False.
    private static bool CheckPassword(string password, out string errorMessage)
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

    // Überprüft, ob das gegebene Zeichen ein Sonderzeichen ist.
    // Parameter:
    //   c: Das zu überprüfende Zeichen.
    // Rückgabewert:
    //   True, wenn das Zeichen ein Sonderzeichen ist, andernfalls False.
    internal static bool IsSpecialCharacter(char c)
    { 
        return "!@#$%^&*()-_=+[]{}|;:'\"<>,.?/~`".Contains(c); 
    }

    // Überprüft, ob ein Benutzername bereits in der Datenbank vorhanden ist.
    // Parameter:
    //   benutzername: Der Benutzername, der überprüft werden soll.
    // Rückgabewert:
    //   True, wenn der Benutzername bereits existiert, andernfalls False.
    internal static bool DoUsernameExist(string benutzername)
    {
        string query = "SELECT COUNT(*) FROM Benutzer WHERE Benutzername = @Benutzername";

        using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
        {
            command.Parameters.AddWithValue("@Benutzername", benutzername);

            int benutzerCount = (int)command.ExecuteScalar();

            return benutzerCount > 0;
        }
    }

    // Überprüft die Gültigkeit der Anmeldeinformationen (Benutzername und Passwort) anhand der Datenbank.
    // Parameter:
    //   benutzername: Der Benutzername, der überprüft werden soll.
    //   passwort: Das Passwort, das überprüft werden soll.
    // Rückgabewert:
    //   True, wenn die Anmeldeinformationen gültig sind, andernfalls False.
    internal static bool Validation(string benutzername, string passwort)
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

                        string inputPasswortHash = PasswortUtility.HashPassword(passwort, salt);

                        return storedPasswortHash == inputPasswortHash;
                    }
                }
            }
            return false;   // Benutzername nicht gefunden
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Login war nicht erfolgreich. {ex.Message}");
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
