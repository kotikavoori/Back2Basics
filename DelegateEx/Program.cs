using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateEx
{
    internal class Program
    {
        private void Main(string[] args)
        {
            CallbackEvents Events = new CallbackEvents();
            Events.UpdateEventResultreceivedEvent += Events_UpdateEventResultreceivedEvent1;
            Callback(10);

            //Operation obj = new Operation();
            //obj.updateMethod(Callback);
            //Console.Read();
            Thread.Sleep(10000);
        }

        private static void Events_UpdateEventResultreceivedEvent1(object Sender, CustomArgs e)
        {
            throw new NotImplementedException();
        }

        public static void Callback(int i)
        {
            Events_UpdateEventResultreceivedEvent1("koti", new CustomArgs() { id = 1, name = "Test" });
            Console.WriteLine(i);
        }
    }

    public class Operation
    {
        public delegate void SendUpdate(int i);

        public void updateMethod(SendUpdate updateObj)
        {
            for (int i = 0; i < 100; i++)
            {
                updateObj(i);
                //Update everyone , ewho subscribed to me
            }
        }
    }
}