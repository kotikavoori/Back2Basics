using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Inheritance
    {
        //static void Main(string[] args)
        //{
        //    //Base2 d = new Base2();
        //    //Base1 b1 = new Base2();

        //    //d.Add(1,2);
        //    //b1.Add(1,2);

        //    A b = new B();
        //    b.Add();

        //    Console.Read();
        //}
    }

    interface IA
    {
        void Add();
    }

    interface IB
    {
        void Add();

    }

    class A2 : IA
    {
        public A2()
        {
            Console.WriteLine("Class A");

        }
        public void Add()
        {
            Console.WriteLine("Class A-Add()");

        }
    }

    class B2 : A2,IB
    {
        public B2()
        {
            Console.WriteLine("Class B");

        }
        public void Add()
        {
            Console.WriteLine("Class B, DIff Behaviour");
        }
    }

    class Base1
    {
        public Base1()
        {
            Console.WriteLine("Base1");

        }
        public void Add(int a , int b)
        {
            Console.WriteLine("Base1 Add()");
        }
    }

    class Base2 : Base1
    {
        public Base2()
        {
            Console.WriteLine("Base2");
        }
        public new void Add(int a, int b)
        {
            Console.WriteLine("Base2 Add()");
        }

    }

    class Derived : Base2
    {
        public Derived()
        {
            Console.WriteLine("Derived");
        }
        public new void Add(int a, int b)
        {
            Console.WriteLine("Derived Add()");
        }
    }
}