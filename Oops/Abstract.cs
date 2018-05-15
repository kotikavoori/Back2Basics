using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal abstract class AbstractTest : MyClass
    {
        static AbstractTest()
        {
            Console.Write("Abs Ctor");
        }

        public abstract void Add();

        //public virtual void YouCanChangeMe()
        //{
        //}
    }

    public class MyClass
    {
    }

    internal interface IInterface1
    {
    }

    internal interface IInterface : IInterface1
    {
        void Add();
    }

    internal class DerivedClass : AbstractTest
    {
        public DerivedClass()
        {
            Console.Write("Derived Ctor");
        }

        public override void Add()
        {
            throw new NotImplementedException();
        }
    }

    internal class Client
    {
        //static void Main(string[] args)
        //{
        //    DerivedClass d = new DerivedClass();
        //    Console.Read();
        //}
    }
}