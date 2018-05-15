using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    using System;

    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = word.Length - 1,int j = 0; i >= 0; i--, j++)
            {
                word[j] = word[i];
            }
            if (sb.ToString() == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("121"));
            Console.Read();
        }
    }
}