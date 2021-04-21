using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    public class ConsoleUserInterface
    {

        public int GetMatrixSize()
        {
            Console.WriteLine("Please enter your board size:");
            int size;
            bool flag = int.TryParse(Console.ReadLine(), out size);

            while (!flag || (size > 9 || size < 3))
            {
                Console.WriteLine("The sizes must be between 3 to 9!\nPlease enter new size.:");
                flag = int.TryParse(Console.ReadLine(), out size);
            }

            return size;
        }




        

    }
}
