using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefandOut
{
    internal class Program
    {
        private static readonly int temp = 0;
        private readonly int temp1 = 0;

        private static int test = 0;

        private static void Main(string[] args)
        {
            int a = 0;

            int b;
            Refex(ref a); // For ref variable , it has to be initialized out side , before refering it
            OutEx(out b); //For Out , the varibale has to get initialized inside method
            Console.Read();
        }

        static Program() // we can update/assign readonly in static constructor
        {
            temp = 20;
        }

        public Program() //  we can initialize/assign readonly in constructor with another variable
        {
            temp1 = 20;
        }

        private static void Refex(ref int num)
        {
            Console.WriteLine(++num);
        }

        private static void OutEx(out int num)
        {
            num = 10; // This has to be initialized
            Console.WriteLine(num++);
        }
    }
}