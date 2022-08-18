using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyConnector : BaseConnector
    {
        //private EnemyController _insect;
        //protected override void Connect()
        //{
        //    Subscribe<StartPlayMessage>(_insect.OnStartPlay);

        //}

        //protected override void Disconnect()
        //{
        //    Unsubscribe<StartPlayMessage>(_insect.OnStartPlay);

        //}
        protected override void Connect()
        {
            throw new System.NotImplementedException();
        }

        protected override void Disconnect()
        {
            throw new System.NotImplementedException();
        }
    }
}
