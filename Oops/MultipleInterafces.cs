using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class MultipleInterafces
    {
        private void test()
        {
            Logger log = new Logger();

            IFileLogger log1 = new Logger();
        }
    }

    internal interface IFileLogger
    {
        void Log();
    }

    internal interface IEventLogger
    {
        void Log();
    }

    internal interface IConsoleLogger
    {
        void Log();
    }

    public class Logger : IFileLogger, IEventLogger, IConsoleLogger
    {
        void IFileLogger.Log()
        {
            throw new NotImplementedException();
        }

        void IEventLogger.Log()
        {
            throw new NotImplementedException();
        }

        void IConsoleLogger.Log()
        {
            throw new NotImplementedException();
        }
    }
}