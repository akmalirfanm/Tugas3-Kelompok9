using Agate.MVC.Base;
using SpaceInvader.Message;


namespace SpaceInvader.Module.ScoreCalculator 
{ 
public class ScoreCalculatorModel : BaseModel, IScoreCalculatorModel
{
        public int Score { get; private set; } = 0;
        public void AddScore()
        {
            Score++;
            SetDataAsDirty();
        }
    }
}
