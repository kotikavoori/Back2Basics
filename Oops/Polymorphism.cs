using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    //class Polymorphism
    //{
    //    static void Main(string[] args)
    //    {
    //        //P1 p1 = new P2();
    //        //p1.add();

    //        //p1 = new P3();
    //        //p1.add();

    //        //A1 a1 = new A1();
    //        //a1.show();

    //        //B1 b1 = new B1();
    //        //b1.show();

    //        //A1 a2 = new B1();
    //        //a2.show();


    //        //A1 a1 = new A1();
    //        //a1.show();
    //        //B1 b1 = new B1();
    //        //b1.show();
    //        C1 c1 = new C1();
    //        c1.show();
    //        //A1 a2 = new B1();
    //        //a2.show();
    //        A1 a3 = new C1();
    //        a3.show();
    //        //B1 b3 = new C1();
    //        //b3.show();

    //        Console.Read();

    //    }
    //}

    //class P1
    //{
    //   public virtual void add()
    //    {
    //        Console.WriteLine("p1");
    //    }
    //}

    //class P2 : P1
    //{
    //    public override void add()
    //    {

    //        Console.WriteLine("p2");
    //    }
    //}

    //class P3 : P1
    //{
    //    public override void add()
    //    {

    //        Console.WriteLine("p3");
    //    }
    //}

    class A1
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: Base Class!");
            
        }
    }

    class B1 : A1
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived Class!");
            
        }
    }

    class C1 : B1
    {
        public new void show()
        {
            Console.WriteLine("Am Here!");
        }
    }

    class A
    {
        public void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public new  void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public  void Test() { Console.WriteLine("C::Test()"); }
    }

    class Program
    {
        //static void Main(string[] args)
        //{

        //    B a1 = new B();
        //    a1.Test();

        //    //A a = new A();
        //    //B b = new B();
        //    //C c = new C();

            

        //    //a.Test(); // output --> "A::Test()"
        //    //b.Test(); // output --> "B::Test()"
        //    //c.Test(); // output --> "C::Test()"

        //    //a = new B();
        //    //a.Test(); // output --> "A::Test()"

        //    //b = new C();
        //    //b.Test(); // output --> "B::Test()"

        //    Console.ReadKey();
        //}
    }

}

//base
//dericed
//am here
//derived
//base--
//derived--