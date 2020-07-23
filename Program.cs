using System;
using System.Reflection;

namespace ContinuousIntegrationDIY
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Version : " + Assembly.GetExecutingAssembly().GetName().Version);
            Console.WriteLine("Hello World!");
        }

    }
}