using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.Audio
{
    public class AudioConnector : BaseConnector
    {
        private AudioController _audio;

        protected override void Connect()
        {
            //Subscribe<UpdateSfxConfigMessage>(_audio.OnUpdateSfxConfig);
            //Subscribe<MoveInsectMessage>(_audio.OnMoveInsect);
            //Subscribe<AddScoreMessage>(_audio.OnAddScore);
            Subscribe<GameOverMessage>(_audio.OnGameOver);
            Subscribe<EnemyHitMessage>(_audio.OnEnemyHit);
            Subscribe<PlayerShootMessage>(_audio.OnPlayerShoot);
            Subscribe<PowerUpMessage>(_audio.OnPowerUp);
        }

        protected override void Disconnect()
        {
            //Unsubscribe<UpdateSfxConfigMessage>(_audio.OnUpdateSfxConfig);
            //Unsubscribe<MoveInsectMessage>(_audio.OnMoveInsect);
            //Unsubscribe<AddScoreMessage>(_audio.OnAddScore);
            Unsubscribe<GameOverMessage>(_audio.OnGameOver);
            Unsubscribe<EnemyHitMessage>(_audio.OnEnemyHit);
            Unsubscribe<PlayerShootMessage>(_audio.OnPlayerShoot);
            Unsubscribe<PowerUpMessage>(_audio.OnPowerUp);
        }
    }
}
