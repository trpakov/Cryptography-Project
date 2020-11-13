using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Exercises
{
    static class ColumnTransposition
    {
        public static char[] M { get; set; } = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ 0123456789".ToCharArray();
        private static char[] key;
        public static char[] Key
        {
            get => key;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value.Count(x => x == value[i]) > 1)
                        throw new ArgumentException($"\nВъведеният ключ съдържа повтарящи се символи, което не е допустимо.");

                foreach (var ch in value)
                    if (!M.Contains(ch))
                        throw new ArgumentOutOfRangeException(ch.ToString(), $"\nВъведеният ключ съдържа символа '{ch.ToString()}', който не е част от множеството допустими символи.");

                key = value;
            }
        }
        static Random rng = new Random();

        public const string TestText = "БАНКА БИОХИМ ОБЯВЯВА ТЪРГ НА 1 МАРТ";
        public const string TestCrypto = "  АНРНХВР БИБТ БО АТАОЯЪ1КИЯГМАМВ А";

        static ColumnTransposition()
        {
            //Key = GenerateKey();
            key = "КРИСТАЛ".ToCharArray();
        }

        public static char[] GenerateKey()
        {
            int length = rng.Next(3, 10);
            var keyArr = new char[length];
            var MCopy = M.ToList();

            for (int i = 0; i < length; i++)
            {             
                var next = MCopy[rng.Next(0, MCopy.Count)];
                MCopy.Remove(next);
                keyArr[i] = next;
            }

            return keyArr;
        }

        public static List<int> EvaluateKey()
        {
            var indexes = Key.Select(x => Array.IndexOf(M, x)).ToList();
            var result = new List<int>(indexes);

            for (int i = 0; i < Key.Length; i++)
            {
                var minIndex = indexes.Where(x => x > -1).Min();
                result[indexes.IndexOf(minIndex)] = i + 1;
                indexes[indexes.IndexOf(minIndex)] = -1;
            }

            return result;
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

            var matrix = new char[numOfBlocks, Key.Length];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = textBlocks[i][j];

            var resultMatrix = new char[numOfBlocks, Key.Length];

            var keyInt = EvaluateKey();

            for (int j = 0; j < keyInt.Count; j++)
                for (int i = 0; i < matrix.GetLength(0); i++)
                    resultMatrix[i, j] = matrix[i, keyInt.IndexOf(j + 1)];

            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                var currentBlock = new StringBuilder(keyInt.Count);

                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                    currentBlock.Append(resultMatrix[i, j]);

                result.Add(currentBlock.ToString());
            }

            return string.Join("", result);
        }

        public static string Decrypt(string crypto)
        {
            var reminder = crypto.Length % Key.Length;
            if (reminder != 0) throw new ArgumentException("Въведена е невалидна криптограма (размерът й не е кратен на размера на ключа).");

            foreach (var ch in crypto)
                if (!M.Contains(ch)) throw new ArgumentOutOfRangeException(ch.ToString(), $"\nКриптограмата съдържа символа '{ch}', който не е част от множеството допустими символи.");

            var numOfBlocks = crypto.Length / Key.Length;
            var textBlocks = new List<string>(Key.Length);
            var result = new List<string>(Key.Length);

            for (int i = 0; i < Key.Length; i++)
                textBlocks.Add(crypto.Substring(i * numOfBlocks, numOfBlocks));

            var matrix = new char[numOfBlocks, Key.Length];

            for (int j = 0; j < matrix.GetLength(1); j++)
                for (int i = 0; i < matrix.GetLength(0); i++)
                    matrix[i, j] = textBlocks[j][i];

            var resultMatrix = new char[numOfBlocks, Key.Length];

            var keyInt = EvaluateKey();

            for (int j = 0; j < keyInt.Count; j++)
                for (int i = 0; i < matrix.GetLength(0); i++)
                    resultMatrix[i, keyInt.IndexOf(j + 1)] = matrix[i, j];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                var currentBlock = new StringBuilder(keyInt.Count);

                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    currentBlock.Append(resultMatrix[i, j]);

                result.Add(currentBlock.ToString());
            }

            return string.Join("", result);
        }
    }
}
