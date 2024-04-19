using System;
using System.Linq;


    public class MAMAJAMA
    {
        public int Sort(int[] digitals)
        {
            if (digitals.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < digitals.Length - 1; i++)
            {
                for (int j = 0; j < digitals.Length - i - 1; j++)
                {
                    if (digitals[j] > digitals[j + 1])
                    {
                        int temp = digitals[j];
                        digitals[j] = digitals[j + 1];
                        digitals[j + 1] = temp;
                    }
                }
            }
            return digitals[3];
        }

        public int Palindrome(string pal)
        {
            if (string.IsNullOrEmpty(pal))
            {
                return 0;
            }

            string lowerCasePal = pal.ToLower();
            if (lowerCasePal.SequenceEqual(lowerCasePal.Reverse()))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Fact(int Fac)
        {
            if (Fac < 0)
            {
                return 0;
            }
            if (Fac == 0)
            {
                return 1;
            }
            else if (Fac > 13) 
            {
                return -1; // Возврат значения, указывающего на ошибку
            }
            else
            {
                return Fac * Fact(Fac - 1);
            }
        } //число больше 13

        public int Fib(int Fiba)
        {
            if (Fiba == 0)
            {
                return 0;
            }
            else if (Fiba == 1 || Fiba == -1)
            {
                return 1;
            }

            else if (Fiba > 1)
            {
                return Fib(Fiba - 1) + Fib(Fiba - 2);
            }
            else
            {
                return 0;
            }
        }

        public int Stroki(string text, string word)
        {
            int count = 0;
            for (int i = 0; i <= text.Length - word.Length; i++)
            {
                if (text.Substring(i, word.Length) == word)
                {
                    count++;
                }
            }
            return count;
        }

        public int Easy(int norm)
        {
            if (norm <= 1)
            {
                return 0;
            }

            for (int i = 2; i <= Math.Sqrt(Math.Abs(norm)); i++)
            {
                if (norm % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        public int ReverseNumber(int x)
        {
            long reversed = 0;
            while (x != 0)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }
            if (reversed > int.MaxValue || reversed < int.MinValue)
            {
                return 0;
            }
            return (int)reversed;
        }

        public string IntToRoman(int num)
        {
            if (num <= 0 || num > 3999)
            {
                return "";
            }

            string roman = "";
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < 13; i++)
            {
                while (num >= values[i])
                {
                    roman += symbols[i];
                    num -= values[i];
                }
            }

            return roman;
        }
    }
