using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    internal class RealTimeStatus
    {
        private static void Main(string[] args)
        {
            Client1 c1 = new Client1();
            c1.RxRealtimeStaus();
            Console.Read();
        }

        public delegate int UpdateStatus(int x);

        public void SendLiveStatus(UpdateStatus updateStatusDelegate)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Updated Status  " + i);

                updateStatusDelegate(i);
            }
        }
    }

    internal class Client1
    {
        public void RxRealtimeStaus()
        {
            RealTimeStatus realTimeStatus = new RealTimeStatus();

            realTimeStatus.SendLiveStatus(ReceivedStatus);
        }

        private int ReceivedStatus(int livestatus)
        {
            Console.WriteLine("Received Status  " + livestatus);
            return livestatus;
        }
    }

    internal class Client2
    {
    }
}