using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESKTOP_SERVICES.Helpers
{
    class HelperSecurity
    {
        public string Encrypt(string plainText, string pass)
        {
            string result = string.Empty;

            System.Security.Cryptography.TripleDESCryptoServiceProvider des =
                    new System.Security.Cryptography.TripleDESCryptoServiceProvider();
            des.IV = new byte[8];

            System.Security.Cryptography.PasswordDeriveBytes pdb =
                    new System.Security.Cryptography.PasswordDeriveBytes(pass, new byte[0]);

            des.Key = pdb.CryptDeriveKey("RC2", "SHA1", 128, new byte[8]);

            using (MemoryStream ms = new MemoryStream(plainText.Length * 2))
            {
                using (System.Security.Cryptography.CryptoStream encStream = new
                    System.Security.Cryptography.CryptoStream(ms, des.CreateEncryptor(),
                    System.Security.Cryptography.CryptoStreamMode.Write))
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    encStream.Write(plainBytes, 0, plainBytes.Length);
                    encStream.FlushFinalBlock();
                    byte[] encryptedBytes = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(encryptedBytes, 0, (int)ms.Length);
                    encStream.Close();
                    ms.Close();
                    result = Convert.ToBase64String(encryptedBytes);
                }
            }
            return result;
        }

        public string Decrypt(string base64String, string pass)
        {
            string result = string.Empty;

            if (base64String != string.Empty)
            {
                System.Security.Cryptography.TripleDESCryptoServiceProvider des =
                    new System.Security.Cryptography.TripleDESCryptoServiceProvider();
                des.IV = new byte[8];
                System.Security.Cryptography.PasswordDeriveBytes pdb =
                    new System.Security.Cryptography.PasswordDeriveBytes(pass, new byte[0]);
                des.Key = pdb.CryptDeriveKey("RC2", "SHA1", 128, new byte[8]);
                byte[] encryptedBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(base64String.Length))
                {
                    using (System.Security.Cryptography.CryptoStream decStream =
                        new System.Security.Cryptography.CryptoStream(ms, des.CreateDecryptor(),
                            System.Security.Cryptography.CryptoStreamMode.Write))
                    {
                        decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                        decStream.FlushFinalBlock();
                        byte[] plainBytes = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(plainBytes, 0, (int)ms.Length);
                        result = Encoding.UTF8.GetString(plainBytes);
                    }
                }

            }
            return result;
        }
    }
}
