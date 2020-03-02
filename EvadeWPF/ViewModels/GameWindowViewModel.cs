﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EvadeWPF.Annotations;
using EvadeWPF.Helpers;
using EvadeWPF.Interfaces;
using EvadeWPF.Models;

namespace EvadeWPF.ViewModels
{
    public class GameWindowViewModel : NotifyPropertyChanged
    {
        private IGameEngine engine;

        private ObservableCollection<IBoardItem> _boardItems;
        public ObservableCollection<IBoardItem> BoardItems
        {
            get { return _boardItems; }
            set
            {
                _boardItems = value;
                RaisePropertyChanged();
            }
        }

        public GameWindowViewModel(IGameEngine ge)
        {
            engine = ge;

        }

        private ICommand _newGameCommand;
        public ICommand NewGameCommand
        {
            get
            {
                if(_newGameCommand == null)
                    _newGameCommand = new RelayCommand(p => NewGame());
                return _newGameCommand;
            }
        }

        private void NewGame()
        {
            _boardItems = new ObservableCollection<IBoardItem>();

            for (int i = 0; i <= 35; i++)
            {
                _boardItems.Add(new BoardSquare());
            }
        }
    }
}