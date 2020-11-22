using System;
using System.Linq;
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
            Application.Run(new CryptoTest());

            //do
            //{
            //    Console.WriteLine("=============================");
            //    Console.WriteLine("Изберете метод за криптиране:\n1. Шифър на Цезар\n2. Директно заместване\n3. Многоазбучно заместване\n4. Матрично заместване\n0. Изход\n");
            //    Console.WriteLine("=============================");
            //    var key = Console.ReadKey(true);

            //    if (!"01234".ToCharArray().Contains(key.KeyChar)) continue;
            //    if (key.KeyChar == '0') Environment.Exit(0);

            //    Console.WriteLine("Въведете явния текст:\n");
            //    var text = Console.ReadLine();
            //    string encryptionResult = String.Empty;
            //    string decryptionResult = String.Empty;
            //    var directSubstResult = new Tuple<string, string>(string.Empty, string.Empty);

            //    try
            //    {
            //        switch (key.KeyChar)
            //        {
            //            case '1':
            //                if(text == "")
            //                    text = CaesarCipher.TestText;

            //                encryptionResult = CaesarCipher.Encrypt(text);
            //                decryptionResult = CaesarCipher.Decrypt(encryptionResult);

            //                Console.WriteLine("\n\nЯвен текст:\n");
            //                Console.WriteLine(text + '\n');
            //                Console.WriteLine("\nРезултат от криптирането:\n");
            //                Console.WriteLine(encryptionResult + '\n');
            //                Console.WriteLine("\nРезултат от декриптирането:\n");
            //                Console.WriteLine(decryptionResult + "\n\n");
            //                break;

            //            case '2':
            //                if(text == "")
            //                    text = DirectSubstitution.TestText;

            //                directSubstResult = DirectSubstitution.Encrypt(text);
            //                decryptionResult = DirectSubstitution.Decrypt(directSubstResult.Item2); // или (directSubsResult.Item1, false), ако интервалите са некриптирани

            //                Console.WriteLine("\n\nЯвен текст:\n");
            //                Console.WriteLine(text + '\n');

            //                Console.WriteLine("\n\nРезултат от криптирането (без шифроване на интервалите):\n");
            //                Console.WriteLine(directSubstResult.Item1 + '\n');
            //                Console.WriteLine("\n\nРезултат от криптирането (c шифроване на интервалите):\n");
            //                Console.WriteLine(directSubstResult.Item2 + '\n');

            //                Console.WriteLine("\nРезултат от декриптирането:\n");
            //                Console.WriteLine(decryptionResult + "\n\n");
            //                break;

            //            case '3':
            //                if(text == "")
            //                    text = PolyalphabeticSubstitution.TestText;

            //                encryptionResult = PolyalphabeticSubstitution.Encrypt(text);
            //                decryptionResult = PolyalphabeticSubstitution.Decrypt(encryptionResult);

            //                Console.WriteLine("\n\nЯвен текст:\n");
            //                Console.WriteLine(text + '\n');

            //                Console.WriteLine("\n\nРезултат от криптирането:\n");
            //                Console.WriteLine(encryptionResult + '\n');
            //                Console.WriteLine("\nРезултат от декриптирането:\n");
            //                Console.WriteLine(decryptionResult + "\n\n");
            //                break;

            //            case '4':
            //                if(text == "")
            //                    text = MatrixSubstitution.TestText;

            //                encryptionResult = MatrixSubstitution.Encrypt(text);
            //                decryptionResult = MatrixSubstitution.Decrypt(encryptionResult);

            //                Console.WriteLine("\n\nЯвен текст:\n");
            //                Console.WriteLine(text + '\n');

            //                Console.WriteLine("\n\nРезултат от криптирането:\n");
            //                Console.WriteLine(encryptionResult + '\n');
            //                Console.WriteLine("\nРезултат от декриптирането:\n");
            //                Console.WriteLine(decryptionResult + "\n\n");
            //                break;
            //        }
            //    }
            //    catch (ArgumentException e)
            //    {
            //        Console.WriteLine(e.Message + '\n');
            //        continue;
            //    }
            //} while (true);

        }
    }

}
