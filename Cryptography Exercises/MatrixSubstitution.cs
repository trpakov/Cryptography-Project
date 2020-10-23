using System;
using System.Text;
using System.Linq;

namespace Cryptography_Exercises
{
    static class MatrixSubstitution
    {
        public static char[] M {get; set;} = "0123456789АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ -:,".ToCharArray();
        private static char[,] A;

        private static string key;
        public static string Key
        {
            get => key;
            set
            {
                if (value.Length != 5)
                    throw new ArgumentOutOfRangeException(value, "Ключът трябва да е с дължина от 5 символа.");

                foreach (var ch in value)
                {
                    if(!M.Contains(ch)) throw new ArgumentOutOfRangeException(ch.ToString(), $"\nВъведеният ключ съдържа символа '{ch.ToString()}', който не е част от множеството допустими символи.");
                }

                key = value;
            }
        }

        public static char[,] APrime;
        private static Random rng = new Random();

        public static string TestText {get; set;} = "ПРЕХВЪРЛЯТ СЕ В АРХИВ СЛЕДНИТЕ ДОКУМЕНТИ Б 36481 312 - АВТ, М 82134 656 - АКД, К 44251 348 - ВРН, Т 11426 273 - ММИ";
        public const string TestCrypto = "Щ825О288Г 692ДО6ЪГ5ФММДЯСО552С6 БЮ-Ц-А2Ф6ЬСЛИДШЦДЕБТСЕ8КЮЕЗ8ЦМЯКГГФСОЗЖМТДМФ ФДЦ6ФЩКЗБМШМК6НСФЮЧПС28БСЩКИ6ТЮЛ87М9 Ф";

        static MatrixSubstitution()
        {
            key = GenerateKey(); // random key
            key = "АРХИВ"; // explicit test key

            GenerateMatrices();

        }

        public static void GenerateMatrices()
        {
            A = new char[M.Length, M.Length];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    A[i, k] = M[(k + i) % M.Length];
                }
            }

            APrime = new char[key.Length + 1, M.Length];

            for (int k = 0; k < M.Length; k++)
            {
                APrime[0, k] = M[k];
            }

            for (int i = 1; i < APrime.GetLength(0); i++)
            {
                int correctRow = 0;

                for (int q = 1; q < A.GetLength(0); q++)
                {
                    if (A[q, 0] == key[(i - 1) % key.Length])
                    {
                        correctRow = q;
                        break;
                    }
                }

                for (int k = 0; k < APrime.GetLength(1); k++)
                {
                    APrime[i, k] = A[correctRow, k];
                }
            }
        }

        public static string GenerateKey()
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
            GenerateMatrices();
                
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
