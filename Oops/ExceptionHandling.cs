using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{

    public class TestStatic
    {
        public static int TestValue;

        public int sample = 0;

        static TestStatic()
        {
            Console.WriteLine("Static ctor");

            if (TestValue == 0)
            {
                TestValue = 10;
            }

        }

        public TestStatic()
        {
            if (TestValue == 0)
            {
                Console.WriteLine("Regular ctor");
                TestValue = 5;
            }
        }


        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }
            Console.WriteLine("TestValue : " + TestValue);

        }
    }
    class ExceptionHandling
    {

        static void Main(string[] args)
        {

            CtorEX obj = new CtorEX() { };


            

            Console.Read();


            //TestStatic t = new TestStatic();
            //t.sample = 100;

            //t.Print();

            ////DivByZero(r=>12);
            //Console.Read();

        }

       static int value = 0;
        private static int DivByZero(Func<object, int> p)
        {
            return p(value);
        }

        public static void DivByZero()
        {
            try
            {
                int a = 2, b = 20 ; 
                int c = a / b;
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("DivideByZeroException Catch");

                string s = string.Empty;
                try
                {
                    s[1].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sub Super Catch");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Super Catch");
            }

            finally
            {
                Console.WriteLine("Im in finally");
            }

        }

    }

}
