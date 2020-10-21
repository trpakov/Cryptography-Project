using System;
using System.Collections.Generic;
using System.Linq;

namespace Cryptography_Exercises
{
    static class DirectSubstitution
    {
        public static char[] M { get; set; } = "АБВГДЕИКЛМНОПРСТУФХЯ0123456789NYUD №-Ъ\"S".ToCharArray();
        public static Dictionary<char, int> SubstitutionCodes { get; private set; } = new Dictionary<char, int>(M.Length);
        public const string TestText = "ОТ СМЕТКА С № 320 201 642 881 7 НА БАНКА \"БИОХИМ\" ДА СЕ ПРЕХВЪРЛЯТ USD 10 000 000 В КОРЕСПОНДЕНТСКА БАНКА NY 20361-8975";
        public const string TestCrypto = "12 16 35 15 10 6 16 8 1 35 15 35 36 35 24 23 21 35 23 21 22 35 27 25 23 35 29 29 22 35 28 35 11 1 35 2 1 11 8 1 35 39 2 7 12 19 7 10 39 35 5 1 35 15 6 35 13 14 6 19 3 38 14 9 20 16 35 33 40 34 35 22 21 35 21 21 21 35 21 21 21 35 3 35 8 12 14 6 15 13 12 11 5 6 11 16 15 8 1 35 2 1 11 8 1 35 31 32 35 23 21 24 27 22 37 29 30 28 26";

        static DirectSubstitution()
        {
            for (int i = 0; i < M.Length; i++)
                SubstitutionCodes[M[i]] = i + 1;
        }

        public static Tuple<string, string> Encrypt(string plainText = TestText)
        {
            if (plainText.Length > 300) throw new ArgumentOutOfRangeException(plainText, "Допуска се явен текст с дължина не по-голяма от 300 символа.");

            var plainTextAsChars = plainText.ToCharArray();
            var resultWithEncryptedSpaces = new string[plainText.Length];
            var resultWithoutEncryptedSpaces = new string[plainText.Length];

            for (int i = 0; i < plainTextAsChars.Length; i++)
            {

                if (!M.Contains(plainTextAsChars[i])) throw new ArgumentOutOfRangeException(plainTextAsChars[i].ToString(), $"\nЯвният текст съдържа символа '{plainTextAsChars[i]}', който не е част от множеството допустими символи.");

                resultWithEncryptedSpaces[i] = SubstitutionCodes[plainTextAsChars[i]].ToString();
                resultWithoutEncryptedSpaces[i] = SubstitutionCodes[plainTextAsChars[i]].ToString();

                if (plainText[i] == ' ')
                    resultWithoutEncryptedSpaces[i] = "  ";

            }

            return new Tuple<string, string>(String.Join(" ", resultWithoutEncryptedSpaces), String.Join(" ", resultWithEncryptedSpaces));
        }

        public static string Decrypt(string cryptogram, bool areSpacesEncrypted = true)
        {
            string[] input;

            if (areSpacesEncrypted)
            {
                input = cryptogram.Split(' ');
                char[] result = new char[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    result[i] = SubstitutionCodes.Single(x => x.Value == int.Parse(input[i])).Key;
                }

                return new String(result);
            }
            else
            {
                input = cryptogram.Split(new string[] { "    " }, StringSplitOptions.None);
                List<char> output = new List<char>();

                for (int word = 0; word < input.Length; word++)
                {
                    var wordSymbols = input[word].Split(' ');
                    for (int symbol = 0; symbol < wordSymbols.Length; symbol++)
                    {
                        output.Add(SubstitutionCodes.Single(x => x.Value == int.Parse(wordSymbols[symbol])).Key);
                    }

                    if (word != input.Length - 1) output.Add(' ');
                }

                return new string(output.ToArray());
            }

        }
    }

}
