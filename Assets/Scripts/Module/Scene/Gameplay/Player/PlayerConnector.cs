using Agate.MVC.Base;
using SpaceInvader.Message;
using SpaceInvader.Module.Input;
using SpaceInvader.Module.Message;
using System;
using UnityEngine;

namespace SpaceInvader.Module.PlayerController
{
    public class PlayerConnector : BaseConnector
    {
        public PlayerController _playerController;

        protected override void Connect()
        {
             Subscribe <PlayerMoveMessage>(OnControllerMove);
             Subscribe<PlayerBulletShootMessage>(OnPlayerShoot);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlayerMoveMessage>(OnControllerMove);
            Unsubscribe<PlayerBulletShootMessage>(OnPlayerShoot);
        }

        void OnControllerMove(PlayerMoveMessage message)
        {
            _playerController.Onmove(message.X);
        }

        void OnPlayerShoot(PlayerBulletShootMessage message)
        {
            _playerController.OnShoot();
        }


    }
}