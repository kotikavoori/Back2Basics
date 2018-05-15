using System;

namespace Puzzles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine( Ispalindrome("as121sa"));
            Console.WriteLine(new string(ReverseStringOneArray("hello man".ToCharArray())));
            // Console.WriteLine(getlength("koti".ToCharArray()));
            //reverse("koti is".ToCharArray(), 0, 3);
            Console.WriteLine();

            // reverseww("hello this is koti".ToCharArray());

            //  revwrdbywrd("hello this is koti".ToCharArray());
            Console.Read();
        }

        private static bool Ispalindrome(string s)
        {
            Char[] arr = s.ToCharArray();

            char[] rev = ReverseString(arr);

            return CompareStrings(arr, rev);
        }

        private static char[] ReverseString(char[] input)
        {
            char[] rev = new char[input.Length];

            int len = rev.Length - 1;

            for (int i = len; i >= 0; i--)
            {
                rev[len - i] = input[i];
            }

            return rev;
        }

        private static char[] ReverseStringOneArray(char[] input)
        {
            //            char[] rev = new char[input.Length];

            int len = input.Length - 1;

            for (int i = len; i >= 0; i--)
            {
                char temp = input[len - i];
                input[len - i] = input[i];

                input[i] = temp;
            }

            return input;
        }

        private static bool CompareStrings(char[] s1, char[] s2)
        {
            bool isequal = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    isequal = true;
                }
            }
            return isequal;
        }

        private static char[] ReverseWordByWord(char[] input)
        {
            char[] output = new char[input.Length];

            int len = input.Length - 1;

            int from = 0, to = 0;

            for (int i = 0; i < len; i++)
            {
                if (input[i] == '\0')
                {
                    output = reverse(from, i, input);
                }
            }

            return output;
        }

        private static char[] reverse(int from, int i, char[] input)
        {
            char[] output = new char[input.Length];

            return output;
        }

        private static int getlength(char[] str)
        {
            int i = -1, length = 0;
            while (str[i + 1] != '\0')
            {
                i++;
                length++;
            }
            return length;
        }

        private void reversewithrecursion(char[] str1, int index, int size)
        {
            char temp;
            temp = str1[index];
            str1[index] = str1[size - index];
            str1[size - index] = temp;
            if (index == size / 2)
            {
                return;
            }
            reversewithrecursion(str1, index + 1, size);
        }

        private static void revwrdbywrd(char[] str)
        {
            int i = 0, j = 0, k = 0, x, len;
            //char[] str = new char[100];
            char[,] str1 = new char[100, 90]; char temp;

            for (i = 0; str[i - 1] != '\0'; i++)
            {
                if (str[i] == ' ')
                {
                    str1[k, j] = '\0';
                    k++;
                    j = 0;
                }
                else
                {
                    str1[k, j] = str[i];
                    j++;
                }
            }
            str1[k, j] = '\0';

            /* reverses each word of a given string */
            for (i = 0; i <= k; i++)
            {
                len = str1.Length;
                for (j = 0, x = len - 1; j < x; j++, x--)
                {
                    temp = str1[i, j];
                    str1[i, j] = str1[i, x];
                    str1[i, x] = temp;
                }
            }
            for (i = 0; i <= k; i++)
            {
                Console.WriteLine(str1[i, i]);
            }
        }

        private int Check_Armstrong(int Number)
        {
            double Temp, Reminder, Times = 0, Sum = 0;
            Temp = Number;

            while (Temp != 0)
            {
                Times = Times + 1;
                Temp = Temp / 10;
            }

            for (Temp = Number; Temp > 0; Temp = Temp / 10)
            {
                Reminder = Temp % 10;
                Sum = Sum + Math.Pow(Reminder, Times);
            }
            if (Number == Sum)
                return 1;
            else
                return 0;
        }

        /* C Program for Perfect Number */

        private int Perfect_Number(int Number)
        {
            int i, Sum = 0;

            for (i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                    Sum = Sum + i;
            }

            if (Sum == Number)
                return 1;
            else
                return 0;
        }

        /* C Program to Find Prime Number  */

        private int Prime_Number(int Number)
        {
            int i, Count = 0;

            for (i = 2; i <= Number / 2; i++)
            {
                if (Number % i == 0)
                {
                    Count++;
                }
            }
            if (Count == 0 && Number != 1)
                return 1;
            else
                return 0;
        }

        private int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        private int fib(int n)
        {
            int a = 0, b = 1, c, i;
            if (n == 0)
                return a;
            for (i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        public static void reverseww(char[] c)
        {
            reverse(c, 0, c.Length - 1);

            int wordStart = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ' ')
                {
                    reverse(c, wordStart, i - 1);
                    wordStart = i + 1;
                }
                else if (i == c.Length - 1)
                {
                    reverse(c, wordStart, i);
                }
            }

            Console.WriteLine(new string(c));
        }

        public static void reverse(char[] c, int i, int j)
        {
            if (i >= j)
                return;
            for (int k = i; k <= (i + j) / 2; k++)
            {
                char temp = c[k];
                c[k] = c[i + j - k];
                c[i + j - k] = temp;
            }
        }
    }
}