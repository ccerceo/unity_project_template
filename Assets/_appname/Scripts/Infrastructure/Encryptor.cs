using System;
using System.IO;
using System.Security.Cryptography;

namespace Appname.Infrastructure
{
    public class Encryptor
    {
        private byte[] _key = { 2, 156, 133, 229, 159, 11, 199, 124, 199, 47, 183, 178, 49, 167, 48, 159, 10, 59, 220, 102, 136, 3, 14, 93, 45, 184, 74, 51, 154, 222, 77, 108 };
        private byte[] _vector = { 65, 23, 213, 44, 134, 164, 119, 176, 159, 186, 170, 54, 56, 43, 56, 97 };

        public string Encrypt(string plainText)
        {
            byte[] bytes;

            using (var aes = new AesManaged())
            {
                aes.Key = _key;
                aes.IV = _vector;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (var streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        bytes = memoryStream.ToArray();
                    }
                }
            }

            var result = Convert.ToBase64String(bytes);
            return result;
        }

        public string Decrypt(string encryptedText)
        {
            var bytes = Convert.FromBase64String(encryptedText);

            string plaintext = null;

            using (var aes = new AesManaged())
            {
                aes.Key = _key;
                aes.IV = _vector;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var memoryStream = new MemoryStream(bytes))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (var streamReader = new StreamReader(cryptoStream))
                        {
                            plaintext = streamReader.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;
        }
    }
}
