using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo
{
    internal class Liskov
    {
    }

    public abstract class Shape //Base Class
    {
        public abstract int Area();
    }

    public class Rectangle : Shape
    {
        public int Height = 10;
        public int Width = 5;

        public override int Area()
        {
            return Height * Width;
        }
    }

    public class Square : Shape
    {
        public int Sides = 5;

        public override int Area()
        {
            return Sides * Sides;
        }
    }
}