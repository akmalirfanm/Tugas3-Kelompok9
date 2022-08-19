using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.GameOver
{
    public class GameOverConnector : BaseConnector
    {
        private GameOverController _gameover;

        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_gameover.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_gameover.OnGameOver);
        }
    }
}