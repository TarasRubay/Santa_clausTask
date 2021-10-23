using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"SantaClient.bin";
            ConsoleMenu menu = new ConsoleMenu(path);
            menu.Start();
                 
        }
    }
}
