using Agate.MVC.Base;
using SpaceInvader.Message;
using SpaceInvader.Module.Input;
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
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlayerMoveMessage>(OnControllerMove);
        }

        void OnControllerMove(PlayerMoveMessage message)
        {
            _playerController.Onmove(message.X);
        }


    }
}