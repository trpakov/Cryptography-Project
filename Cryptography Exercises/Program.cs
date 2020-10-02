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
                Console.WriteLine("=============================");
                Console.WriteLine("Изберете метод за криптиране:\n1. Шифър на Цезар\n0. Изход\n");
                var key = Console.ReadKey(true);

                if (!"01".ToCharArray().Contains(key.KeyChar)) continue;
                if (key.KeyChar == '0') Environment.Exit(0);

                Console.WriteLine("Въведете явния текст:\n");
                var text = Console.ReadLine();
                string encryptionResult = String.Empty;
                string decryptionResult = String.Empty;

                try
                {
                    switch (key.KeyChar)
                    {
                        case '1':
                            encryptionResult = CaesarCipher.Encrypt(text);
                            decryptionResult = CaesarCipher.Decrypt(encryptionResult);
                            break;
                        case '2':
                            throw new NotImplementedException();
                        case '3':
                            throw new NotImplementedException();
                        case '4':
                            throw new NotImplementedException();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + '\n');
                    continue;
                }


                Console.WriteLine("\n\nРезултат от криптирането:\n");
                Console.WriteLine(encryptionResult + '\n');
                Console.WriteLine("\nРезултат от декриптирането:\n");
                Console.WriteLine(decryptionResult + "\n\n");
            } while (true);

        }
    }

    static class CaesarCipher
    {
        public static char[] M { get; private set; } = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 .,:/".ToCharArray();

        public static string Encrypt(string plainText)
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

}
