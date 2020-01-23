using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using mvvm.controller;
using mvvm.viewmodel;

namespace mvvm.Tests
{
    [TestFixture]
    public class Tests
    {

        GameLogic gameLogic = new GameLogic();
        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        [Test]
        public void TestCheckInputValue_Input_IsBetweenOneAndNine()
        {
            bool inputVerified = true;
            bool inputCheckedValue = gameLogic.CheckInputValue(8);
            Assert.AreEqual(inputVerified, inputCheckedValue);
        }

        [Test]
        public void TestCheckIndexValue_Input_IsExistingIndex()
        {
            bool indexVerified = true;
            bool indexCheckedValue = gameLogic.CheckIndexValue(8);
            Assert.AreEqual(indexVerified, indexCheckedValue);
        }

        [Test]
        public void TestCheckFullRow_Dictionary_IsFullValidRow()
        {
            bool rowVerified = true;
            bool rowChecked = gameLogic.CheckFullRow(mainPageViewModel.GameCellValuesList);
            Assert.AreEqual(rowVerified, rowChecked);
        }

        public void TestCheckFullColumn_Dictionary_IsFullValidColumn()
        {
            bool columnVerified = true;
            bool columnChecked = gameLogic.CheckFullColumn(mainPageViewModel.GameCellValuesList);
            Assert.AreEqual(columnVerified, columnChecked);
        }

        public void TestCheckFullBox_Dictionary_IsFullValidBox()
        {
            bool boxVerified = true;
            bool boxChecked = gameLogic.CheckFullBox(mainPageViewModel.GameCellValuesList);
            Assert.AreEqual(boxVerified, boxChecked);
        }

    }
}
