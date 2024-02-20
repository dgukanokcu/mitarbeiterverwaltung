using System;
using System.Security.Cryptography;
using System.Text;

namespace BTS_Mitarbeiterverwaltung.Utils
{
    internal class PasswortUtility
    {
        public static string HashPasswort(string passwort, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswortBytes = Encoding.UTF8.GetBytes(passwort + salt);
                byte[] hashedBytes = sha256.ComputeHash(saltedPasswortBytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static string GeneriereZufaelligesSalt(int length = 16)
        {
            const string erlaubteZeichen = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=<>?";

            StringBuilder saltBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(erlaubteZeichen.Length);
                saltBuilder.Append(erlaubteZeichen[index]);
            }

            return saltBuilder.ToString();
        }
    }
}
