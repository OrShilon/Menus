using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildAndRunInterface.Run();
            BuildAndRunDelegate.Run();
            Console.WriteLine("thank you for using our menu! exit program...");
            Thread.Sleep(2000);
        }
    }
}
