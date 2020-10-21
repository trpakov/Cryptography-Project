using System;
using System.Text;
using System.Linq;

namespace Cryptography_Exercises
{
    static class PolyalphabeticSubstitution
    {
        public static char[] M {get; set;} = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 \"-*".ToCharArray();
        private static string key;
        public static string Key
        {
            get => key;
            set
            {
                foreach (var ch in key)
                {
                    if(!M.Contains(ch)) throw new ArgumentOutOfRangeException(ch.ToString(), $"\nВъведеният ключ съдържа символа '{ch.ToString()}', който не е част от множеството допустими символи.");
                }

                key = value;
            }
        }

        private static Random rng = new Random();
        public static string TestText { get; set; } = "*ФИРМА TRIPP LITE ДЕПОЗИРА СУМАТА 300 000 USD ПО СМЕТКА 306 18 216-4 В БАНКА \"ХЕБРОС\"*";
        public const string TestCrypto = "МFЦЩBПН66WY8Л2V8SЕЧФCЬЦЦЩУЛECЬОЬУЛЖ*БК9ЕБН77RЕEЯНAЬУЬЯПНВБЖЕЖЙНБВЖЗЙЛУЙРОЦЯПНКGУКFЯEКО";

        static PolyalphabeticSubstitution()
        {
            key = GenerateKey(); // random key
            key = "МОНИТОР"; // explicit test key
        }

        public static string GenerateKey()
        {
            int keyLength = rng.Next(0, M.Length);
            var sb = new StringBuilder(keyLength);

            for (int i = 0; i < keyLength; i++)
            {
                sb.Append(M[rng.Next() % M.Length]);
            }

           return sb.ToString();
        }

        public static string Encrypt(string plainText)
        {
            if (plainText.Length > 300) throw new ArgumentOutOfRangeException(plainText, "Допуска се явен текст с дължина не по-голяма от 300 символа.");

            if (plainText[0] != '*' || plainText[plainText.Length - 1] != '*')
                throw new ArgumentException("Съобщението трябва да започва и завършва със символа '*'.");

            char[] result = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                if (!M.Contains(plainText[i])) throw new ArgumentOutOfRangeException(plainText[i].ToString(), $"\nЯвният текст съдържа символа '{plainText[i]}', който не е част от множеството допустими символи.");

                result[i] = M[(Array.IndexOf(M, plainText[i]) + Array.IndexOf(M, key[i % key.Length]) + 1) % M.Length];
            }

            return new string(result);
        }

        public static string Decrypt(string cryptogram)
        {
            char[] result = new char[cryptogram.Length];

            for (int i = 0; i < cryptogram.Length; i++)
			{
                var difference =  Array.IndexOf(M, cryptogram[i]) - Array.IndexOf(M, key[i % key.Length]) - 1;
                if(difference < 0)
                    difference = M.Length - Math.Abs(difference);

                result[i] = M[difference];
			}

            return new string(result);
        }

    }

}
