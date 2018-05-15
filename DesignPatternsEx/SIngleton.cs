using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsEx.SingletonEx
{
    public class Singleton
    {
        private static Singleton _instance = null;

        private Singleton()
        {
        }

        private static Object lockThis = new Object();

        public static Singleton getInstance()
        {
            lock (lockThis)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }
    }

    internal class Client
    {
        public Client()
        {
            Singleton s = new Singleton();

            Singleton.getInstance();
        }
    }
}