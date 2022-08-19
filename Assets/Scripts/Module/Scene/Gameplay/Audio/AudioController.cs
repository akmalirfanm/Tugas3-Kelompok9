using System.Collections;
using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.Audio
{
    public class AudioController : ObjectController<AudioController, AudioModel, IAudioModel, AudioView>
    {

        //public void OnMoveInsect(MoveInsectMessage message)
        //{
        //    _view.PlayBirdWingsSfx();
        //}

        //public void OnAddScore(AddScoreMessage message)
        //{
        //    _view.PlayAddScoreSfx();
        //}

        public void OnGameOver(GameOverMessage message)
        {
            _view.PlayGameOverSfx();
        }

        public void OnEnemyHit(EnemyHitMessage message)
        {
            _view.enemyHitSfx();
        }

        public void OnPlayerShoot(PlayerShootMessage message)
        {
            _view.playerShootSfx();
        }

        public void OnPowerUp(PowerUpMessage message)
        {
            _view.powerupSfx();
        }
    }
}
