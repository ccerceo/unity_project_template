using System;
using UnityEngine;

namespace Appname.Infrastructure
{
    public static class LocalStorage
    {
        private static Encryptor _encryptor;

        static LocalStorage()
        {
            _encryptor = new Encryptor();
        }

        public static void Set(string key, object obj)
        {
            SetString(key, JsonUtility.ToJson(obj));
        }

        public static T Get<T>(string key)
        {
            return JsonUtility.FromJson<T>(GetString(key));
        }

        public static void SetString(string key, string value)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value");
            }

            PlayerPrefs.SetString(key, _encryptor.Encrypt(value));
        }

        public static string GetString(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            var encryptedValue = PlayerPrefs.GetString(key);
            return string.IsNullOrEmpty(encryptedValue) ? string.Empty : _encryptor.Decrypt(encryptedValue);
        }
    }
}
