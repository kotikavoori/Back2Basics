using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newKeyWord
{
    internal class BC
    {
        public void Display()
        {
            System.Console.WriteLine("BC::Display");
        }
    }

    internal class DC : BC
    {
        public new void Display()
        {
            System.Console.WriteLine("DC::Display");
        }
    }

    internal class Demo
    {
        public static void Main()
        {
            DC obj = new DC();
            obj.Display();
            Console.Read();
        }

        private void test(dynamic x, Object b)
        {
        }
    }
}