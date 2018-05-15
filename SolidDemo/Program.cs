using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Shape s = new Square(); //Base class Obj
            Console.WriteLine(s.Area());

            Square sq = new Square(); //Derived class obj
            Console.WriteLine(sq.Area()); //result is same as above

            s = new Rectangle(); //BAse obj
            Console.WriteLine(s.Area());

            Rectangle rect = new Rectangle(); //derived obj
            Console.WriteLine(rect.Area()); //same as above result

            Console.Read();
        }
    }
}