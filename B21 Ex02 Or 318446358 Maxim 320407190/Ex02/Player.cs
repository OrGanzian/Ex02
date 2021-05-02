using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Player
    {
        private int score = 0;
        private string m_playerName;
        private char m_symbol;
        public Player(string i_PlayerName,char i_Symbol)
        {
            m_playerName = i_PlayerName;
            m_symbol = i_Symbol;
        }

        private void AddScore()
        {
            score++;
        }

        public char getSymbol()
        {
            return this.m_symbol;
        }

        /*public int Score { get; private set; }

        public string PlayerName { get; private set; }*/

    }
}
