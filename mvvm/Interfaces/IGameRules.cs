using System;
using System.Collections.Generic;

namespace mvvm.interfaces
{
    public interface IGameRules
    {
            bool CheckInputValue(int input);
            bool CheckIndexValue(int index);
            bool CheckFullRow(IDictionary<int, int> dictionary);
            bool CheckFullColumn(IDictionary<int, int> dictionary);
            bool CheckFullBox(IDictionary<int, int> dictionary);
    }
}