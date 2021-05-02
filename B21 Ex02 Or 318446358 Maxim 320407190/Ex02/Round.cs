using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Round
    {
        PcPlayer m_PcPlayer = new PcPlayer();
        ConsoleUserInterface consoleUserInterface=new ConsoleUserInterface();
        private Board m_Board;
        private bool m_VersusFriend; ////true 1v1

      
        public Round(bool i_Versus, int i_size)
        {
            this.m_Board = new Board(i_size);
            this.m_VersusFriend = i_Versus; 
        }

        public void StartSingleRoundVersusFriend()
        {
            bool isIndexAvailable = false;
            bool playAgain = true;
            int turn = 0;

            while (!m_Board.IsFull() && playAgain)
            {

                this.consoleUserInterface.ClearScreen();
                this.consoleUserInterface.PrintBoard(this.m_Board);

                int row = this.consoleUserInterface.GetRowPlayerTurnInput();
                int column = this.consoleUserInterface.GetColumnPlayerTurnInput();

                if (turn%2==0) // turn for 'X'
                {

                     isIndexAvailable =this.m_Board.SetValueByIndex(row, column, 'X');
                    while (!isIndexAvailable)
                    {
                         row = this.consoleUserInterface.GetRowPlayerTurnInput();
                        isIndexAvailable = this.m_Board.SetValueByIndex(row, column, 'X');


                    }

                }
                else
                {

                    if (this.m_VersusFriend)
                    {
                        this.m_Board.SetValueByIndex(row, column, 'O'); // turn for 'O'
                    }
                    else //play against PC logic
                    {
                        this.m_PcPlayer.PlaySingleTurn(this.m_Board);


                    }

                }

                turn++;
                this.consoleUserInterface.PrintBoard(this.m_Board);

              

            }


            
            if (consoleUserInterface.IsPlayAagain())
            {
                this.m_Board.Clear();
            }

        }

       
       


    }
}
