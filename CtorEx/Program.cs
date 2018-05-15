using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorEx
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CtorEX ctorEX = new CtorEX();

            Console.Read();
        }
    }

    public class CtorEX
    {
        static CtorEX()
        {
            Console.WriteLine("Static Constructor");
        }

        //private CtorEX()
        //{
        //    Console.WriteLine("Static Constructor");
        //}

        public CtorEX() : this(10)
        {
            Console.WriteLine("Main Constructor");
        }

        public CtorEX(int a)
        {
            Console.WriteLine("Param Constructor");
        }
    }
}