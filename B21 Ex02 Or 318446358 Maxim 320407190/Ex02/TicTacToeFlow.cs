using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class TicTacToeFlow
    {
        private Board m_Board;
        private bool m_VersusFriend;
       

        public TicTacToeFlow(bool i_Versus, int i_size)
        {
            this.m_Board = new Board(i_size);
            this.m_VersusFriend = i_Versus;

        }

        public Board DisplayBoard
        {
            get
            {
                return this.m_Board;
            }
        }

        public bool IfUserMode
        {
            get
            {
                return this.m_VersusFriend;
            }
        }
        public bool CheckBoardRange(int i_InputNumber)
        {
            bool rangeStatus = false;
            if (i_InputNumber >= 0 && i_InputNumber < this.m_Board.NumOfRows)
            {
                rangeStatus = true;
            }

            return rangeStatus;
        }

        public void setBoardValues(int i_Row,int i_Column,char i_Symbol)
        {
            m_Board.SetValueByIndex(i_Row, i_Column, i_Symbol);
        }

        public bool boardFull()
        {
            return this.m_Board.IsFull();
        }

        public bool checkIfLose(char i_SymbolToCheck)
        {
            return this.m_Board.checkIfMatch(i_SymbolToCheck);
        }

       /* public void StartSingleRoundVersusFriend()
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

                if (turn % 2 == 0) // turn for 'X'
                {

                    isIndexAvailable = this.m_Board.SetValueByIndex(row, column, 'X');
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
*/





    }
}
