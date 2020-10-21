using System;
using System.Linq;

namespace Cryptography_Exercises
{
    static class CaesarCipher
    {
        public static char[] M { get; set; } = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 .,:/".ToCharArray();
        public const string TestText = "ФИРМА KARCHER ТЪРСИ ДА НАЕМЕ СКЛАД НАД 200 КВ.М.";
        public const string TestCrypto = "ЧЛУПГ:NDUFKHU:ХЯУФЛ:ЗГ:РГИПИ:ФНОГЗ:РГЗ:533:НЕ/П/";
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
                if (!M.Contains(cryptogramAsChars[i])) throw new ArgumentOutOfRangeException(cryptogramAsChars[i].ToString(), $"\nКриптограмата съдържа символа '{cryptogramAsChars[i]}', който не е част от множеството допустими символи.");

                int newIndex = (Array.IndexOf(M, cryptogramAsChars[i]) - 3) % M.Length;
                if (newIndex < 0) newIndex = M.Length - Math.Abs(newIndex);

                result[i] = M.ElementAt(newIndex);
            }

            return new String(result);
        }
    }

}
