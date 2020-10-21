using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Exercises
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppGUIForm());

            do
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Изберете метод за криптиране:\n1. Шифър на Цезар\n2. Директно заместване\n3. Многоазбучно заместване\n4. Матрично заместване\n0. Изход\n");
                Console.WriteLine("=============================");
                var key = Console.ReadKey(true);

                if (!"01234".ToCharArray().Contains(key.KeyChar)) continue;
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
                            if(text == "")
                                text = CaesarCipher.TestText;

                            encryptionResult = CaesarCipher.Encrypt(text);
                            decryptionResult = CaesarCipher.Decrypt(encryptionResult);

                            Console.WriteLine("\n\nЯвен текст:\n");
                            Console.WriteLine(text + '\n');
                            Console.WriteLine("\nРезултат от криптирането:\n");
                            Console.WriteLine(encryptionResult + '\n');
                            Console.WriteLine("\nРезултат от декриптирането:\n");
                            Console.WriteLine(decryptionResult + "\n\n");
                            break;

                        case '2':
                            if(text == "")
                                text = DirectSubstitution.TestText;

                            directSubstResult = DirectSubstitution.Encrypt(text);
                            decryptionResult = DirectSubstitution.Decrypt(directSubstResult.Item2); // или (directSubsResult.Item1, false), ако интервалите са некриптирани

                            Console.WriteLine("\n\nЯвен текст:\n");
                            Console.WriteLine(text + '\n');

                            Console.WriteLine("\n\nРезултат от криптирането (без шифроване на интервалите):\n");
                            Console.WriteLine(directSubstResult.Item1 + '\n');
                            Console.WriteLine("\n\nРезултат от криптирането (c шифроване на интервалите):\n");
                            Console.WriteLine(directSubstResult.Item2 + '\n');

                            Console.WriteLine("\nРезултат от декриптирането:\n");
                            Console.WriteLine(decryptionResult + "\n\n");
                            break;

                        case '3':
                            if(text == "")
                                text = PolyalphabeticSubstitution.TestText;

                            encryptionResult = PolyalphabeticSubstitution.Encrypt(text);
                            decryptionResult = PolyalphabeticSubstitution.Decrypt(encryptionResult);

                            Console.WriteLine("\n\nЯвен текст:\n");
                            Console.WriteLine(text + '\n');

                            Console.WriteLine("\n\nРезултат от криптирането:\n");
                            Console.WriteLine(encryptionResult + '\n');
                            Console.WriteLine("\nРезултат от декриптирането:\n");
                            Console.WriteLine(decryptionResult + "\n\n");
                            break;

                        case '4':
                            if(text == "")
                                text = MatrixSubstitution.TestText;

                            encryptionResult = MatrixSubstitution.Encrypt(text);
                            decryptionResult = MatrixSubstitution.Decrypt(encryptionResult);

                            Console.WriteLine("\n\nЯвен текст:\n");
                            Console.WriteLine(text + '\n');

                            Console.WriteLine("\n\nРезултат от криптирането:\n");
                            Console.WriteLine(encryptionResult + '\n');
                            Console.WriteLine("\nРезултат от декриптирането:\n");
                            Console.WriteLine(decryptionResult + "\n\n");
                            break;
                    }
                }
                catch (ArgumentException e)
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

    static class PolyalphabeticSubstitution
    {
        public static char[] M {get; private set;} = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 \"-*".ToCharArray();
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
        private static int counter;
        public static string TestText { get; set; } = "*ФИРМА TRIPP LITE ДЕПОЗИРА СУМАТА 300 000 USD ПО СМЕТКА 306 18 216-4 В БАНКА \"ХЕБРОС\"*";

        static PolyalphabeticSubstitution()
        {
            key = GenerateKey(); // random key
            key = "МОНИТОР"; // explicit test key
        }

        private static string GenerateKey()
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

            if (counter >= 10)
            {
                key = GenerateKey();
                counter = 0;
            }

            char[] result = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                if (!M.Contains(plainText[i])) throw new ArgumentOutOfRangeException(plainText[i].ToString(), $"\nЯвният текст съдържа символа '{plainText[i]}', който не е част от множеството допустими символи.");

                result[i] = M[(Array.IndexOf(M, plainText[i]) + Array.IndexOf(M, key[i % key.Length]) + 1) % M.Length];
            }

            counter++;
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

    static class MatrixSubstitution
    {
        public static char[] M {get; private set;} = "0123456789АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ -:,".ToCharArray();
        private static char[,] A;

        private static string key;
        public static string Key
        {
            get => key;
            set
            {
                if (key.Length != 5)
                    throw new ArgumentOutOfRangeException(key, "Ключът трябва да е с дължина от 5 символа.");

                foreach (var ch in key)
                {
                    if(!M.Contains(ch)) throw new ArgumentOutOfRangeException(ch.ToString(), $"\nВъведеният ключ съдържа символа '{ch.ToString()}', който не е част от множеството допустими символи.");
                }

                key = value;
            }
        }

        public static char[,] APrime;
        private static Random rng = new Random();
        private static int counter;
        public static string TestText {get; set;} = "ПРЕХВЪРЛЯТ СЕ В АРХИВ СЛЕДНИТЕ ДОКУМЕНТИ Б 36481 312 - АВТ, М 82134 656 - АКД, К 44251 348 - ВРН, Т 11426 273 - ММИ";

        static MatrixSubstitution()
        {
            key = GenerateKey(); // random key
            key = "АРХИВ"; // explicit test key

            A = new char[M.Length, M.Length];

            for (int i = 0; i < A.GetLength(0); i++)
			{
                for (int k = 0; k < A.GetLength(1); k++)
			    {
                    A[i,k] = M[(k + i) % M.Length];
			    }
			}

            APrime = new char[key.Length+1, M.Length];

            for (int k = 0; k < M.Length; k++)
			{
                APrime[0,k] = M[k];
			}

            for (int i = 1; i < APrime.GetLength(0); i++)
			{
                int correctRow = 0;

                for (int q = 1; q < A.GetLength(0); q++)
			    {
                    if(A[q,0] == key[(i-1) % key.Length])
                    {
                        correctRow = q;
                        break;
                    }
			    }

                for (int k = 0; k < APrime.GetLength(1); k++)
			    {
                    APrime[i,k] = A[correctRow,k];
			    }
			}

        }

        private static string GenerateKey()
        {
            var sb = new StringBuilder(5);

            for (int i = 0; i < 5; i++)
            {
                sb.Append(M[rng.Next() % M.Length]);
            }

           return sb.ToString();
        }

        public static string Encrypt(string plainText)
        {
            if (counter >= 10)
            {
                key = GenerateKey();
                counter = 0;
            }
                
            char[] result = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
			{
                if (!M.Contains(plainText[i])) 
                    throw new ArgumentOutOfRangeException(plainText[i].ToString(), $"\nЯвният текст съдържа символа '{plainText[i]}', който не е част от множеството допустими символи.");


                int colIndex = -1;
                int rowIndex = -1;

                for (int k = 0; k < APrime.GetLength(1); k++)
			    {
                    if(plainText[i] == APrime[0,k])
                    {
                        colIndex = k;
                        break;
                    }
			    }

                for (int k = 1; k < APrime.GetLength(0); k++)
			    {
                    if(APrime[k,0] == key[i % key.Length])
                    {
                        rowIndex = k;
                        break;
                    }
			    }

                result[i] = APrime[rowIndex,colIndex];
			}
        
            counter++;
            return new string(result);
        }

        public static string Decrypt(string cryptogram)
        {
            char[] result = new char[cryptogram.Length];

            

            for (int i = 0; i < cryptogram.Length; i++)
			{
                int rowIndex = -1;
                int colIndex = -1;

                for (int k = 1; k < APrime.GetLength(0); k++)
			    {
                    if(APrime[k,0] == key[i % key.Length])
                    {
                        rowIndex = k;
                        break;
                    }
			    }

                for (int k = 0; k < APrime.GetLength(1); k++)
			    {
                    if(APrime[rowIndex, k] == cryptogram[i])
                    {
                        colIndex = k;
                        break;
                    }
			    }

                result[i] = APrime[0,colIndex];
			}

            return new string(result);
        }
    }

}
