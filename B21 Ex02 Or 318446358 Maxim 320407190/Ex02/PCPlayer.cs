﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class PcPlayer
    {
        public List<int> RandFreeIndex(List<List<int>> i_ListOfFreeIndecies)
        {
            List<int> indexList = new List<int>();
            Random randomizedNumber = new Random();
            int randomNumber = randomizedNumber.Next(1, i_ListOfFreeIndecies.Count);

            indexList.Add(i_ListOfFreeIndecies[randomNumber][0]);
            indexList.Add(i_ListOfFreeIndecies[randomNumber][1]);

            return indexList;
        }
    }
}
