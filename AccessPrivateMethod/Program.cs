using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessPrivateMethod
{
    using System;
    using System.Reflection;

    internal class Car
    {
        private void priavtemethod()
        {
            Console.WriteLine("Eninge private function\n");
            Console.Read();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //create object of the class
            Car c = new Car();

            //GetMethod : searches for the specified method i.e. "func"
            //with specified binding constraints.

            MethodInfo m = c.GetType().GetMethod("priavtemethod", BindingFlags.NonPublic | BindingFlags.Instance);

            m.Invoke(c, null);// resolves a call to func function at run time.
        }
    }
}