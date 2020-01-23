using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using mvvm.controller;

namespace mvvm.viewmodel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private GameLogic gameLogic;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private IDictionary<int, int> gameCellValuesList;

        public IDictionary<int, int> GameCellValuesList
        {
            get
            {
                return gameCellValuesList;
            }
            set
            {
                gameCellValuesList = value;
                OnPropertyChanged("GameCellValuesList");
            }
        }

        public MainPageViewModel()
        {
            CreateSudokuGame();
        }


        private void CreateSudokuGame()
        {
            gameCellValuesList = new Dictionary<int, int>();
            FillSudokuCells();
        }

        private void FillSudokuCells()
        {
            gameCellValuesList.Add(new KeyValuePair<int, int>(0, 3));
            gameCellValuesList.Add(new KeyValuePair<int, int>(4, 6));
            gameCellValuesList.Add(new KeyValuePair<int, int>(33, 8));
            gameCellValuesList.Add(new KeyValuePair<int, int>(12, 5));

            gameCellValuesList.Add(new KeyValuePair<int, int>(66, 9));
            gameCellValuesList.Add(new KeyValuePair<int, int>(23, 1));
            gameCellValuesList.Add(new KeyValuePair<int, int>(80, 2));
            gameCellValuesList.Add(new KeyValuePair<int, int>(24, 7));

            gameCellValuesList.Add(new KeyValuePair<int, int>(68, 3));
            gameCellValuesList.Add(new KeyValuePair<int, int>(50, 8));
            gameCellValuesList.Add(new KeyValuePair<int, int>(72, 6));
            gameCellValuesList.Add(new KeyValuePair<int, int>(54, 4));

            gameCellValuesList.Add(new KeyValuePair<int, int>(16, 9));
            gameCellValuesList.Add(new KeyValuePair<int, int>(30, 1));
            gameCellValuesList.Add(new KeyValuePair<int, int>(43, 7));
            gameCellValuesList.Add(new KeyValuePair<int, int>(63, 2));
        }

    }
}
