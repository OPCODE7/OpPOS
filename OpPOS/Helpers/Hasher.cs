using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OpPOS.Helpers
{
    internal class Hasher
    {
        /// <summary>
        /// Genera un hash seguro a partir de una cadena de caracteres utilizando PBKDF2 con SHA256.
        /// </summary>
        /// <param name="str">Contraseña en texto plano.</param>
        /// <returns>Cadena codificada en Base64 que contiene el salt y el hash combinado.</returns>
        public string MakeHash(string str)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);

                using (var pbkdf2 = new Rfc2898DeriveBytes(str, salt, 10000, HashAlgorithmName.SHA256))
                {
                    byte[] hash = pbkdf2.GetBytes(32);
                    byte[] hashBytes = new byte[48];
                    Array.Copy(salt, 0, hashBytes, 0, 16);
                    Array.Copy(hash, 0, hashBytes, 16, 32);

                    return Convert.ToBase64String(hashBytes);
                }
            }
        }

        /// <summary>
        /// Verifica si una cadena de caracteres proporcionada coincide con un hash almacenado.
        /// </summary>
        /// <param name="str">cadena en texto plano proporcionada por el usuario.</param>
        /// <param name="storedHash">Hash previamente almacenado en formato Base64.</param>
        /// <returns>True si la cadena es válida, de lo contrario False.</returns>
        public bool VerifyHash(string str, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            using (var pbkdf2 = new Rfc2898DeriveBytes(str, salt, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 16] != hash[i]) return false;
                }
            }
            return true;
        }
    }
}
