using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var d = DirectSubstitution.SubstitutionCodes;
                Console.WriteLine("=============================");
                Console.WriteLine("Изберете метод за криптиране:\n1. Шифър на Цезар\n2. Директно заместване\n0. Изход\n");
                Console.WriteLine("=============================");
                var key = Console.ReadKey(true);

                if (!"012".ToCharArray().Contains(key.KeyChar)) continue;
                if (key.KeyChar == '0') Environment.Exit(0);

                Console.WriteLine("Въведете явния текст:\n");
                var text = Console.ReadLine();
                string encryptionResult = String.Empty;
                string decryptionResult = String.Empty;
                var directSubstResult = new Tuple<string, string>(string.Empty, string.Empty);

                try
                {
                    switch (key.KeyChar)
                    {
                        case '1':
                            encryptionResult = CaesarCipher.Encrypt(text);
                            decryptionResult = CaesarCipher.Decrypt(encryptionResult);

                            Console.WriteLine("\n\nРезултат от криптирането:\n");
                            Console.WriteLine(encryptionResult + '\n');
                            Console.WriteLine("\nРезултат от декриптирането:\n");
                            Console.WriteLine(decryptionResult + "\n\n");
                            break;
                        case '2':
                            directSubstResult = DirectSubstitution.Encrypt(text);
                            decryptionResult = DirectSubstitution.Decrypt(directSubstResult.Item2); // или (directSubsResult.Item1, false), ако интервалите са некриптирани

                            Console.WriteLine("\n\nРезултат от криптирането (без шифроване на интервалите):\n");
                            Console.WriteLine(directSubstResult.Item1 + '\n');
                            Console.WriteLine("\n\nРезултат от криптирането (c шифроване на интервалите):\n");
                            Console.WriteLine(directSubstResult.Item2 + '\n');

                            Console.WriteLine("\nРезултат от декриптирането:\n");
                            Console.WriteLine(decryptionResult + "\n\n");
                            break;
                        case '3':
                            throw new NotImplementedException();
                        case '4':
                            throw new NotImplementedException();
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message + '\n');
                    continue;
                }



            } while (true);

        }
    }

    static class CaesarCipher
    {
        public static char[] M { get; private set; } = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 .,:/".ToCharArray();
        public const string TestText = "ФИРМА KARCHER ТЪРСИ ДА НАЕМЕ СКЛАД НАД 200 КВ.М.";

        public static string Encrypt(string plainText = TestText)
        {
            if (plainText.Length > 80) throw new ArgumentOutOfRangeException(plainText, "Допуска се явен текст с дължина не по-голяма от 80 символа.");

            var plaintTextAsChars = plainText.ToCharArray();
            var result = new char[plainText.Length];

            for (int i = 0; i < plaintTextAsChars.Length; i++)
            {

                if (!M.Contains(plaintTextAsChars[i])) throw new ArgumentOutOfRangeException(plaintTextAsChars[i].ToString(), $"\nЯвният текст съдържа символа '{plaintTextAsChars[i]}', който не е част от множеството допустими символи.");

                result[i] = M.ElementAt((Array.IndexOf(M, plaintTextAsChars[i]) + 3) % M.Length);
            }

            return new String(result);
        }

        public static string Decrypt(string cryptogram)
        {
            var cryptogramAsChars = cryptogram.ToCharArray();
            var result = new char[cryptogram.Length];

            for (int i = 0; i < cryptogramAsChars.Length; i++)
            {
                int newIndex = (Array.IndexOf(M, cryptogramAsChars[i]) - 3) % M.Length;
                if (newIndex < 0) newIndex = M.Length - Math.Abs(newIndex);

                result[i] = M.ElementAt(newIndex);
            }

            return new String(result);
        }
    }

    static class DirectSubstitution
    {
        public static char[] M { get; private set; } = "АБВГДЕИКЛМНОПРСТУФХЯ0123456789NYUD №-Ъ\"S".ToCharArray();
        public static Dictionary<char, int> SubstitutionCodes { get; private set; } = new Dictionary<char, int>(M.Length);
        public const string TestText = "ОТ СМЕТКА С № 320 201 642 881 7 НА БАНКА \"БИОХИМ\" ДА СЕ ПРЕХВЪРЛЯТ USD 10 000 000 В КОРЕСПОНДЕНТСКА БАНКА NY 20361-8975";

        static DirectSubstitution()
        {
            for (int i = 0; i < M.Length; i++)
                SubstitutionCodes[M[i]] = i + 1;
        }

        public static Tuple<string, string> Encrypt(string plainText = TestText)
        {
            if (plainText.Length > 300) throw new ArgumentOutOfRangeException(plainText, "Допуска се явен текст с дължина не по-голяма от 80 символа.");

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
