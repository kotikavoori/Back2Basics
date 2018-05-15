using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class CtorEX
    {
        public CtorEX() : this(10)
        {
            Console.WriteLine("Main Constructor");
        }

        public CtorEX(int a)
        {
            Console.WriteLine("Param Constructor");
        }
    }

   


}
