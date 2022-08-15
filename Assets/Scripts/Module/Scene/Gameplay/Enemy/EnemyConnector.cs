using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.enemy
{
    public class EnemyConnector : BaseConnector
    {
        private EnemyController _insect;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_insect.OnStartPlay);

        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_insect.OnStartPlay);

        }
    }
}
