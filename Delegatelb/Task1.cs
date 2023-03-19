using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatelb
{
    class PrintAs
    {
        public delegate void Delegate(string msg);
        public static void Error(string msg) => Console.WriteLine($"Error: {msg}");
        public static void Warning(string msg) => Console.WriteLine($"Warning: {msg}");
        public static void Request(string msg) => Console.WriteLine($"Request: {msg}");
        public static void Response(string msg) => Console.WriteLine($"Response: {msg}");
        public static void Notification(string msg) => Console.WriteLine($"Notification: {msg}");
    }
}
