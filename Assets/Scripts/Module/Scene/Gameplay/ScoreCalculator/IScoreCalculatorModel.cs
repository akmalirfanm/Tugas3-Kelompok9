using Agate.MVC.Base;

namespace SpaceInvader.Module.ScoreCalculator
{
    public interface IScoreCalculatorModel : IBaseModel
    {
        public int Score { get; }
    }
}