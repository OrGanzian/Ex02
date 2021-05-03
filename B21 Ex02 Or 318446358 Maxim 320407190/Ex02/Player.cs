using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Player
    {
        private int m_Score = 0;
        private string m_PlayerName;
        private char m_Symbol;
        public Player(string i_PlayerName,char i_Symbol)
        {
            m_PlayerName = i_PlayerName;
            m_Symbol = i_Symbol;
        }

        private void AddScore()
        {
            m_Score++;
        }

        public char getSymbol()
        {
            return this.m_Symbol;
        }

        public string getName()
        {
            return this.m_PlayerName;
        }

        /*public int Score { get; private set; }

        public string PlayerName { get; private set; }*/

    }
}
