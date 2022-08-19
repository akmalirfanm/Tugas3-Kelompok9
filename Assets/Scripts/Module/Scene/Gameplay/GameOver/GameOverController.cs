using UnityEngine;
using Agate.MVC.Base;
using Kelompok9.SpaceInvader.Boot;
using SpaceInvader.Utilty;
using SpaceInvader.Message;
//using SpaceInvader.Module.ProgressData;
using SpaceInvader.Module.ScoreCalculator;

namespace SpaceInvader.Module.GameOver
{ 
public class GameOverController : ObjectController<GameOverController,GameOverModel,IGameOverModel,GameOverView>
{
        //private ProgressDataController _progressData;
        private ScoreCalculatorController _scoreCalculator;

        public void OnGameOver(GameOverMessage message)
        {
            //_view.SetCallbacks(OnRestart, OnToMainMenu, OnToExitGame);
            //_model.SetScore(_scoreCalculator.Model.Score);
            //CheckHighScore(_model.Score);
            //_model.SetHighScore(_progressData.Model.Progress.HighScore);
            //_progressData.SaveProgress();
            //_view.Show();
        }
    }
}