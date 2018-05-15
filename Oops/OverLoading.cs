using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class OverLoading
    {
    }

    internal class Test1
    {
        private static void Foo(int x, double y)
        {
            Console.WriteLine("Foo(int x, double y)");
        }

        private static void Foo(double x, int y)
        {
            Console.WriteLine("Foo(double x, int y)");
        }

        //private static void Main()
        //{
        //    Foo(5.001, 10);
        //}
    }

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
            Child c = new Child();
            c.Foo(10);
        }
    }
}