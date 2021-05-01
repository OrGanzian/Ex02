using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    public class Matrix
    {
        private char[,] m_Matrix;
        private int m_Rows;
        private int m_Cols;

        public Matrix(int i_size)
        {
            this.m_Matrix = new char[i_size, i_size];
            this.m_Rows = i_size;
            this.m_Cols = i_size;
        }
        public int NumOfRows
        {
            get
            {
                return m_Rows;
            }
        }

        public int NumOfCols
        {
            get
            {
                return this.m_Cols;
            }
        }

        public char GetValueByIndex(int i_Row, int i_Col)
        {
            
            return this.m_Matrix[i_Row, i_Col];
        }


        public bool SetValueByIndex(int i_Row, int i_Col,char i_iValue) // value is 'X' or 'O'
        {
            bool isOccupied = false;
            if ( (m_Matrix[i_Row, i_Col] != 'X' && m_Matrix[i_Row, i_Col] != 'O') ) 
            {
                this.m_Matrix[i_Row, i_Col] = i_iValue;
                isOccupied = true;

            }
            else
            {
                isOccupied = false;
            }
            return isOccupied;
        }




        public bool IsFull()
        {
            bool flag = true;

            for (int i = 0; i < this.m_Cols; i++)
            {
                for (int j = 0; j < this.m_Rows; j++)
                {
                    if (m_Matrix[i, j] != 'X' && m_Matrix[i, j] != 'O')
                    {
                        flag = false;
                        break;
                    }
                }
                
            }

            return flag;
        }


        public void Clear()
        {

            for (int i = 0; i < this.m_Cols; i++)
            {
                for (int j = 0; j < this.m_Rows; j++)
                {
                    this.m_Matrix[i, j] = ' ';
                }

            }

        }


        public bool CheckCellAvailability
    

        public bool CheckWinner()
        {
            return true;
            //MAX TODO
        }




    }//class






}//namespace
