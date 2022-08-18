using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.ScoreCalculator
{
    public class ScoreCalculatorController : DataController<ScoreCalculatorController, ScoreCalculatorModel, IScoreCalculatorModel>
    {
        public void OnAddScore(AddScoreMessage message)
        {
            _model.AddScore();
            Publish<UpdateScoreMessage>(new UpdateScoreMessage(_model.Score));
        }
    }
}