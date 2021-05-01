using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Round
    {
        PCPlayer pcPlayer = new PCPlayer();
        ConsoleUserInterface consoleUserInterface=new ConsoleUserInterface();
        private Matrix m_Matrix;
        private bool m_VersusFriend; ////true 1v1

      
        public Round(bool i_Versus, int i_size)
        {
            this.m_Matrix = new Matrix(i_size);
            this.m_VersusFriend = i_Versus;
         
           
        }

        public void StartSingleRoundVersusFriend()
        {
            bool isIndexAvailable = false;
            bool playAgain = true;
            int turn = 0;

            while (!m_Matrix.IsFull() && playAgain)
            {

                this.consoleUserInterface.ClearScreen();
                this.consoleUserInterface.PrintMatrix(this.m_Matrix);

                int row = this.consoleUserInterface.GetRowPlayerTurnInput();
                int column = this.consoleUserInterface.GetColumnPlayerTurnInput();

                if (turn%2==0) // turn for 'X'
                {

                     isIndexAvailable =this.m_Matrix.SetValueByIndex(row, column, 'X');
                    while (!isIndexAvailable)
                    {
                         row = this.consoleUserInterface.GetRowPlayerTurnInput();
                        isIndexAvailable = this.m_Matrix.SetValueByIndex(row, column, 'X');


                    }

                }
                else
                {

                    if (this.m_VersusFriend)
                    {
                        this.m_Matrix.SetValueByIndex(row, column, 'O'); // turn for 'O'
                    }
                    else //play against PC logic
                    {
                        this.pcPlayer.PlaySingleTurn(this.m_Matrix);


                    }

                }

                turn++;
                this.consoleUserInterface.PrintMatrix(this.m_Matrix);

              

            }


            
            if (consoleUserInterface.IsPlayAagain())
            {
                this.m_Matrix.Clear();
            }

        }

        public void StartSingleRoundVersusPC()
        {
         // TODO
        }

        public bool  


    }
}
