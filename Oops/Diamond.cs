using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Diamond
{
    class Diamond
    {
        //static void Main(string[] args)
        //{

        //    var c = new B();
        //    c.Add();
        //    Console.Read();
        //}

    }

    interface A1
    {
        void Add();
    }

    class B1 : A1
    {
        public void Add()
        {
            Console.WriteLine("Interface A");
        }
    }

    interface C1 : A1
    {
        new void Add();
    }

    class D1 : B1, C1
    {
        public new void Add()
        {
            Console.WriteLine("Interface C");
        }

    }
}



