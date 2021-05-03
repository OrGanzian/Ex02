﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex02;

namespace Ex02
{
    class Player
    {
        private int m_Score = 0;
        private string m_PlayerName;
        private char m_Symbol;
        private ePlayerType m_PlayerType;

        public Player(string i_PlayerName, char i_Symbol, ePlayerType i_PlayerType)
        {
            this.m_PlayerName = i_PlayerName;
            this.m_Symbol = i_Symbol;
            this.m_PlayerType = i_PlayerType;
        }

        public ePlayerType PlayerType
        {
            get
            {
                return m_PlayerType;
            }
        }

        private void AddScore()
        {
            m_Score++;
        }

        public char getSymbol()//Property
        {
            return this.m_Symbol;
        }

        public string getName()//Property
        {
            return this.m_PlayerName;
        }
    }
}
