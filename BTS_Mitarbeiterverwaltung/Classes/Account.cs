using BTS_Mitarbeiterverwaltung.Classes;
using BTS_Mitarbeiterverwaltung.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Account
{
    public static void CreateUser(string username, string password, string confirmPassword)
    {
        try
        {
            // Überprüfen, ob Benutzername bereits existiert
            if (DoUsernameExist(username))
            {
                throw new Exception("Benutzername bereits vergeben.");
            }

            // Überprüfen, ob Benutzername und Passwort gültig sind (z. B. nicht leer)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Benutzername und Passwort dürfen nicht leer sein.");
            }

            // Überprüfen, ob Passwort und Passwortbestätigung übereinstimmen
            if (password != confirmPassword)
            {
                throw new Exception("Passwort und Passwortbestätigung stimmen nicht überein. Bitte überprüfen Sie Ihr Passwort!");
            }

            // Generiere zufälliges Salt
            string salt = PasswortUtility.GeneriereZufaelligesSalt();


            string insertQuery = "INSERT INTO Benutzer (Benutzername, PasswortHash, Salt) VALUES (@Benutzername, @PasswortHash, @Salt)";

            using (SqlCommand command = new SqlCommand(insertQuery, SqlVariable.connection))
            {
                // Setze Parameter für Benutzername, PasswortHash, Salt und AktuelleRolle

                command.Parameters.AddWithValue("@Benutzername", username);
                command.Parameters.AddWithValue("@PasswortHash", PasswortUtility.HashPasswort(password, salt));
                command.Parameters.AddWithValue("@Salt", salt);

                // Führe SQL-Abfrage aus
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Benutzer erfolgreich erstellt!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            // Behandlung von Ausnahmen
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
    public static bool DoUsernameExist(string benutzername)
    {
        // Annahme: SqlVariable.connection ist bereits geöffnet

        string query = "SELECT COUNT(*) FROM Benutzer WHERE Benutzername = @Benutzername";

        using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
        {
            command.Parameters.AddWithValue("@Benutzername", benutzername);

            int benutzerCount = (int)command.ExecuteScalar();

            return benutzerCount > 0;
        }
    }

}
