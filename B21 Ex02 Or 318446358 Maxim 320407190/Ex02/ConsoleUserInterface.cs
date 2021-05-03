using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex02.ConsoleUtils;
using Ex02;

namespace Ex02
{
    public class ConsoleUserInterface
    {
        private const int k_MinBoardSize = 3;
        private const int k_MaxBoardSize = 9;
        private TicTacToeFlow m_GameFlow;
        private Player m_Player1;
        private Player m_Player2;
        private Player m_CurrentPlayer;

        public void InitializeGame()
        {
            Console.WriteLine("Welcome to Reversed TicTacToe Game :)");
            int size = GetBoardSize();
            m_Player1 = new Player("First Player", 'X', ePlayerType.User);
            m_Player2 = new Player("Second Player", 'O', getOpponentType());
            m_GameFlow = new TicTacToeFlow(size);
            startSingleGame();
            /*TODO:  
            1. Play multiple games
            2. Add Display scores
            3. Add Q to exit
            4. Fix method names
            */

         /*   while (true)
            {
                startSingleGame(); //1 game
            }
            */
        }

        
        private void startSingleGame()
        {
            m_CurrentPlayer = m_Player1;
            PrintBoard(m_GameFlow.DisplayBoard);

            while (true)
            {
                if (m_CurrentPlayer.PlayerType == ePlayerType.User)
                {
                    userTurn();
                }
                else//PC Move
                {
                    pcTurn();
                }

                PrintBoard(m_GameFlow.DisplayBoard);

                if (m_GameFlow.boardFull())
                {
                    Console.WriteLine("The board is full, No one wins at this Round");
                    break;
                }

                if (m_GameFlow.checkIfLose(m_CurrentPlayer.getSymbol()))
                {
                    Console.WriteLine("{0} Lose! :(((", m_CurrentPlayer.getName());
                    break;
                }

                togglePlayerTurn();
            }
        }

        private ePlayerType getOpponentType()
        {
            ePlayerType typeOfPlayer = ePlayerType.User;
            Screen.Clear();
            Console.WriteLine(string.Format("Who do you want to play against?{0}{0}Press 'ENTER' to Player vs Player mode,{0}Press 'C' to Play vs Computer", Environment.NewLine));
            string vText = Console.ReadLine();

            if (vText.ToLower() == "c")
            {
                typeOfPlayer = ePlayerType.Computer;
            }

            return typeOfPlayer;

        }

        private void userTurn()
        {
            Console.WriteLine("[{0}] is playing,you are [X]", m_CurrentPlayer.getName());
            int row = GetRowPlayerTurnInput();
            int column = GetColumnPlayerTurnInput();

            while (!setCoordinates(row, column, m_CurrentPlayer.getSymbol()))
            {
                Screen.Clear();
                PrintBoard(m_GameFlow.DisplayBoard);
                Console.WriteLine(string.Format("This Index is allready occupied,use another Index"));
                row = GetRowPlayerTurnInput();
                column = GetColumnPlayerTurnInput();
            }

        }

        private void pcTurn()
        { 
            List<int> listOf2RandomizedIndecies = m_GameFlow.GetRandomizedIndeciesByPC();
            setCoordinates(listOf2RandomizedIndecies[0], listOf2RandomizedIndecies[1], m_CurrentPlayer.getSymbol());
        }

        private bool setCoordinates(int i_Row,int i_Column,char i_Symbol)
        {
            return m_GameFlow.setBoardValues(i_Row, i_Column, i_Symbol);
        }

        private void togglePlayerTurn()
        {
            m_CurrentPlayer = getNextPlayer();
        }

        private Player getNextPlayer()
        {
            return m_CurrentPlayer == m_Player1 ? m_Player2 : m_Player1;
        }

        public int GetBoardSize()
        {
            Console.WriteLine(string.Format("Please enter TicTacToe Board game dimensions: ({0}-{1}) ", k_MinBoardSize, k_MaxBoardSize));
            int size;
            bool inputFlag = int.TryParse(Console.ReadLine(), out size);

            while (!inputFlag || (size > k_MaxBoardSize || size < k_MinBoardSize))
            {
                Screen.Clear();
                Console.WriteLine(string.Format("Invalid input,Please enter board size ({0}-{1})", k_MinBoardSize, k_MaxBoardSize));
                inputFlag = int.TryParse(Console.ReadLine(), out size);
            }

            return size;
        }

        public void PrintBoard(Board i_Board)//TODO :Fix drawing sizes + Fix indexes
        {
            StringBuilder matrixText = new StringBuilder();
            StringBuilder separationRow = new StringBuilder();
            Screen.Clear();

            separationRow.Append("  ");
            for (int i = 1; i <= i_Board.NumOfCols; i++)
            {
                matrixText.AppendFormat("   {0} ", i);
                separationRow.Append("====");
            }

            separationRow.Append("=");
            matrixText.Append("\n");
            for (int i = 0; i < i_Board.NumOfRows; i++)
            {
                matrixText.AppendFormat("{0} ", i);
                for (int j = 0; j < i_Board.NumOfCols; j++)
                {
                    matrixText.AppendFormat("| {0} ", i_Board.GetValueByIndex(i, j));
                }

                matrixText.AppendFormat("| \n{0} \n", separationRow);
            }

            Console.WriteLine(matrixText);
        }

        public int GetRowPlayerTurnInput()
        {
            Console.WriteLine("Please enter Row:");
            int row;
            bool inputFlag = int.TryParse(Console.ReadLine(), out row);

            while (!inputFlag || !m_GameFlow.CheckBoardRange(row))
            {
                Screen.Clear();
                PrintBoard(m_GameFlow.DisplayBoard);
                Console.WriteLine(string.Format("Your input for Row is not correct,try correct index:"));
                inputFlag = int.TryParse(Console.ReadLine(), out row);
            }

            return row;
        }

        public int GetColumnPlayerTurnInput()
        {
            Console.WriteLine("Please enter Column:");
            int column;
            bool inputFlag = int.TryParse(Console.ReadLine(), out column);

            while (!inputFlag || !m_GameFlow.CheckBoardRange(column))
            {
                Screen.Clear();
                PrintBoard(m_GameFlow.DisplayBoard);
                Console.WriteLine(string.Format("Your input for Column is not correct,try correct index:"));
                inputFlag = int.TryParse(Console.ReadLine(), out column);
            }

            return column;
        }

        public  bool IsPlayAagain()
        {
            string input;
            bool flag = false;

            do
            {
                Console.WriteLine("Do you want to play again? y/n");
                input = Console.ReadLine();
            }
            while (input.ToLower() != "y" && input.ToLower() != "n");

            if (input.ToLower() == "y")
            {
                flag = true;
            }

            return flag;
        }

    }
}
