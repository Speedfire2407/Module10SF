using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenCast
{
    internal class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.WriteLine(message);
        }

        void ILogger.Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }
    }
}
