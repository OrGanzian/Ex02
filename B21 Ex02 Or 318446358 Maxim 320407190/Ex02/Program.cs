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
            Matrix mat = new Matrix( 6);
            ConsoleUserInterface ui = new ConsoleUserInterface();
            ui.ToText(mat);


            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

    }
}
