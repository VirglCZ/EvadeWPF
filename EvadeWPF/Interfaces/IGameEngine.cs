﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppShared;
using EvadeLogic;
using EvadeWPF.Models;

namespace EvadeWPF.Interfaces
{
    public interface IGameEngine
    {
        void StartEngine();
        GameManager gameManager { get; }
        void StopEngine();
        event Action<string> OutputMessage;
        event Action<string> RaiseEndGameTriggered;
        event Action<bool> EngineThinkingChanged;
        bool IsSelectValid(IBoardItem boardItem);
        bool IsMoveValid(IBoardItem boardItem);
        void GameTurn(bool redo);
        void NewGame();
        void AddUnitsFromGameBoard(ObservableCollection<IBoardItem> boardItems);
        void PlayBestMove();
        void UndoMove();
        void RedoMove();
        void CheckAITurn(AILevels aILevel, bool isTrue = false);
        void PlayMoveHistory(List<List<int>> moveHistory);
        void AsyncCancelledInUI();
    }
}
