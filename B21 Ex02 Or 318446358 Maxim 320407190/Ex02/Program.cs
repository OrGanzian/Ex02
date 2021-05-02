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
            ConsoleUserInterface consoleUserInterface = new ConsoleUserInterface();
            consoleUserInterface.InitializeGame();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

    }
}
