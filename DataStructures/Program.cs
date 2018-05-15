using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Example.SUb();
            //Example example = new Example();
           // example.Add();
            Console.Read();
        }
    }

    public class Example
    {
        static Example()
        {
            Console.WriteLine("Staticc Constructor");
        }
       public static void SUb() { }
        public Example()
        {
            Console.WriteLine("Regular Constructor");
        }

        public void Add()
        {
            Console.WriteLine("Method from Example");
        }
        
    }
}
