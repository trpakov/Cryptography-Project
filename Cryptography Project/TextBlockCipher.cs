using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Exercises
{
    static class TextBlockCipher
    {
        public static char[] M { get; set; } = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ 0123456789".ToCharArray();
        private static char[] key;
        public static char[] Key
        {
            get => key;
            set
            {
                List<int> digits = new List<int>(value.Length);
                for (int i = 1; i < value.Length + 1; i++)
                    digits.Add(i);

                foreach (var ch in value)
                    if (!digits.Contains(int.Parse(ch.ToString()))) throw new ArgumentException($"\nВъведеният ключ трябва да съдържа числата от 1 до своя размер.");

                key = value;
            }
        }
        static Random rng = new Random();

        public const string TestText = "БАНКА БИОХИМ ОБЯВЯВА ТЪРГ НА 01 МАРТ";
        public const string TestCrypto = "ААКБНБХО ИМБОИ ВАВЯЯТГР ЪН0 А РА1М Т";

        static TextBlockCipher()
        {
            //key = GenerateKey();
            key = "41532".ToCharArray();
        }

        public static char[] GenerateKey()
        {
            var length = rng.Next(2, 10);

            List<int> digits = new List<int>(length);
            for (int i = 1; i < length+1; i++)
                digits.Add(i);

            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int index = rng.Next(0, digits.Count);
                sb.Append(digits[index]);
                digits.RemoveAt(index);
            }

            return sb.ToString().ToCharArray();
        }

        public static string Encrypt(string plainText)
        {
            foreach (var ch in plainText)
                if (!M.Contains(ch)) throw new ArgumentOutOfRangeException(ch.ToString(), $"\nЯвният текст съдържа символа '{ch}', който не е част от множеството допустими символи.");

            var reminder = plainText.Length % Key.Length;
            if (reminder != 0)
                for (int i = 0; i < Key.Length - reminder; i++)
                    plainText += " ";

            var numOfBlocks = plainText.Length / Key.Length;
            var textBlocks = new List<string>(numOfBlocks);
            var result = new List<string>(numOfBlocks);

            for (int i = 0; i < numOfBlocks; i++)
                textBlocks.Add(plainText.Substring(i * Key.Length, Key.Length));

            foreach (var block in textBlocks)
            {
                var blockSB = new StringBuilder(block);
                var resultBlockSB = new StringBuilder(block);

                for (int i = 0; i < block.Length; i++)
                {
                    int index1 = i;
                    int index2 = int.Parse(Key[i].ToString()) - 1;

                    resultBlockSB[index2] = blockSB[index1];
                }

                result.Add(resultBlockSB.ToString());
            }

            return string.Join("", result);
        }

        public static string Decrypt(string crypto)
        {
            if (crypto.Length % Key.Length != 0)
                throw new ArgumentException("Веведена е невалидна криптограма (размерът й не е кратен на размера на ключа).");

            foreach (var ch in crypto)
                if (!M.Contains(ch)) throw new ArgumentOutOfRangeException(ch.ToString(), $"\nКриптограмата съдържа символа '{ch}', който не е част от множеството допустими символи.");

            var reminder = crypto.Length % Key.Length;
            if (reminder != 0)
                for (int i = 0; i < Key.Length - reminder; i++)
                    crypto += " ";

            var numOfBlocks = crypto.Length / Key.Length;
            var textBlocks = new List<string>(numOfBlocks);
            var result = new List<string>(numOfBlocks);

            for (int i = 0; i < numOfBlocks; i++)
                textBlocks.Add(crypto.Substring(i * Key.Length, Key.Length));

            foreach (var block in textBlocks)
            {
                var blockSB = new StringBuilder(block);
                var resultBlockSB = new StringBuilder(block);

                for (int i = 0; i < block.Length; i++)
                {
                    int index1 = i;
                    int index2 = int.Parse(Key[i].ToString()) - 1;

                    resultBlockSB[index1] = blockSB[index2];
                }

                result.Add(resultBlockSB.ToString());
            }

            return string.Join("", result).TrimEnd();
        }
    }
}
