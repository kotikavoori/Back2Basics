using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace async
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
            Console.Read();
        }


        static async void ReadFile()
        {
            Task<byte[]> task = Method1();


            Console.Write("Helo");
            await task;

            Console.WriteLine(task.Result.Length);
        }

        static async Task<byte[]> Method1()
        {
            // Thread.Sleep(10000);
            return await Task.Run(() =>  );

        }
    }
}
