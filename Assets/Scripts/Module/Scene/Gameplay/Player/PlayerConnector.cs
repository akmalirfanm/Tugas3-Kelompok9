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
             Subscribe <PlayerMove>(OnControllerMove);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlayerMove>(OnControllerMove);
        }

        void OnControllerMove(PlayerMove message)
        {
            _playerController.move(message.X);
            Debug.Log("aaaa");
        }
        // Start is called before the first frame update

    }
}