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

        public char GetPlaceValue(int i_Row, int i_Col)
        {
            return this.m_Matrix[i_Row, i_Col];
        }

















    }//class






}//namespace
