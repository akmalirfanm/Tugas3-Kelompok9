using UnityEngine;
using Agate.MVC.Base;

namespace SpaceInvader.Module.Audio
{
    public class AudioView : ObjectView<IAudioModel>
    {
        [SerializeField]
        private AudioSource _gameOverSfx;
        [SerializeField]
        private AudioSource _enemyHitSfx;
        [SerializeField]
        private AudioSource _playerShootSfx;
        [SerializeField]
        private AudioSource _powerupSfx;


        public void PlayGameOverSfx()
        {
            _gameOverSfx.Play();
        }
        public void enemyHitSfx()
        {
            _enemyHitSfx.Play();
        }

        public void playerShootSfx()
        {
            _playerShootSfx.Play();
        }

        public void powerupSfx()
        {
            _powerupSfx.Play();
        }

        protected override void InitRenderModel(IAudioModel model)
        {
            //_gameOverSfx.mute = model.IsMuted;
        }

        protected override void UpdateRenderModel(IAudioModel model)
        {
            //_gameOverSfx.mute = model.IsMuted;
        }
    }
}
