using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  CheckPalindrome("woww");

            string normalStr = "koti test";
            string reverseStr = string.Empty;

            for (int i = 0; i < normalStr.Length; i++)
            {
                reverseStr = normalStr[i] + reverseStr;
            }
            Console.WriteLine(reverseStr); //Output : rorriMteNtoD si sihT
            Console.ReadKey();
        }

        private static bool CheckPalindrome(string CheckString)
        {
            if (CheckString == null || CheckString.Length == 0)
            {
                return false;
            }
            int strMaxIndex = CheckString.Length - 1;
            for (int i = 0; i < CheckString.Length / 2; i++)
            {
                if (CheckString[i] != CheckString[strMaxIndex - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}