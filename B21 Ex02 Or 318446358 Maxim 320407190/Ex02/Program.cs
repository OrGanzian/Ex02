using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Program
    {
        public static void Main()
        {
            //test
            ConsoleUserInterface consoleUserInterface = new ConsoleUserInterface();
            consoleUserInterface.StartGame();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

    }
}
