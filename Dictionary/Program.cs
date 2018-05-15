using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            KeyValuePair<int, int> keyValuePair = new KeyValuePair<int, int>(10, 20); //simple key value pair

            Dictionary<int, int> dictionary = new Dictionary<int, int>(); //collection of kvp
            dictionary.Add(1, 2);

            Hashtable hashtable = new Hashtable(dictionary); //collection of kvp , but not type specific

            ArrayList arrayList = new ArrayList(); // its an extension to array , we can have any type

            HashSet<int> hashSet = new HashSet<int>();

            Console.Read();
        }
    }
}