using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
   public class CallbackDelegates
    {
        public delegate void DelegateUpdate(object Sender , CustomArgs e);
    }

    public class CustomArgs
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
