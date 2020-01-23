using System;
using System.Collections.Generic;
using mvvm.interfaces;

namespace mvvm.controller
{
    public class GameLogic : IGameRules
    {
        public GameLogic()
        {
        }

        public bool CheckInputValue(int input)
        {
            // ToDo check input value
            return true;
        }

        public bool CheckIndexValue(int index)
        {
            // ToDo check index value
            return true;
        }

        public bool CheckFullRow(IDictionary<int, int> dictionary)
        {
            // ToDo check if one row is full
            return true;
        }

        public bool CheckFullColumn(IDictionary<int, int> dictionary)
        {
            // ToDo check if one column is full
            return true;
        }

        public bool CheckFullBox(IDictionary<int, int> dictionary)
        {
            // ToDo check if one box is full
            return true;
        }
    }
}
