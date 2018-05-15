using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int count = 0;
            if ((sortedArray.Length == 2) && (sortedArray[2] >lessThan))
            {
                count = 2;
            }
            else
            {
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    if (sortedArray[i] > lessThan)
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }

        public  void main(string[] args)
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
            Console.Read();
        }
    }
}
