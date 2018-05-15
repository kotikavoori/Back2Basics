using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadEx
{
    internal class Parent
    {
        public void Foo(int x)
        {
            Console.WriteLine("Parent.Foo(int x)");
        }
    }

    internal class Child : Parent
    {
        public void Foo(double y)
        {
            Console.WriteLine("Child.Foo(double y)");
        }
    }

    internal class Test
    {
        private static void Main()
        {
            //  Foo(10);

            Child c = new Child();
            c.Foo(10);

            Console.Read();
        }

        private static void Foo(int x)
        {
            Console.WriteLine("Foo(int x)");
        }

        private static void Foo(int x, int y = 5)
        {
            Console.WriteLine("Foo(int x, int y = 5)");
        }

        private static void Foo(int x, int y = 5, int z = 10)
        {
            Console.WriteLine("Foo(int x, int y = 5, int z = 10)");
        }
    }
}