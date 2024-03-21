using System;
using System.Security.Cryptography;
using System.Text;

namespace BTS_Mitarbeiterverwaltung.Utils
{
    internal class PasswortUtility
    {
        // Hashed das angegebene Passwort unter Verwendung des SHA256-Hash-Algorithmus in Kombination mit einem Salt.
        // Parameter:
        //   password: Das zu hashende Passwort.
        //   salt: Saltwert, der mit dem Passwort kombiniert wird.
        // Rückgabe:
        //   Ein String, der das gehashte Passwort repräsentiert.
        internal static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Generiert eine zufällige Salt-Zeichenfolge mit der angegebenen Länge.
        // Parameter:
        //   length (optional): Die Länge der generierten Salt-Zeichenfolge (Standardwert ist 16).
        // Rückgabe:
        //   Eine zufällig generierte Salt-Zeichenfolge.
        internal static string GenerateRandomSalt(int length = 16)
        {
            const string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=<>?";

            StringBuilder saltBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(allowedCharacters.Length);
                saltBuilder.Append(allowedCharacters[index]);
            }

            return saltBuilder.ToString();
        }
    }
}
