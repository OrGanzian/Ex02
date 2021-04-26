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

        public void ToText(Matrix i_matrix)
        {
            StringBuilder matrixText = new StringBuilder();
            StringBuilder separationRow = new StringBuilder();

            for (int i = 1; i <= i_matrix.NumOfCols; i++)
            {
                matrixText.AppendFormat("  {0} ", i);
                separationRow.Append("====");
            }

            separationRow.Append("=");
            matrixText.Append("\n");
            for (int i = 0; i < i_matrix.NumOfRows; i++)
            {
                for (int j = 0; j < i_matrix.NumOfCols; j++)
                {
                    matrixText.AppendFormat("| {0} ", i_matrix.GetPlaceValue(i,j));
                }

                matrixText.AppendFormat("| \n{0} \n", separationRow);
            }

            Console.WriteLine(matrixText);
        }

        
        public  bool GetOpponet() // the method return true for  
        {
            bool flag = true;
            Console.WriteLine("Who do you want to play against?\npress Enter to 1v1 mode, enter C to play against the computer ");
            string vText = Console.ReadLine();

            if (vText.ToLower() == "c")
            {
                flag = false;
            }

            return flag;
        }



    }
}
