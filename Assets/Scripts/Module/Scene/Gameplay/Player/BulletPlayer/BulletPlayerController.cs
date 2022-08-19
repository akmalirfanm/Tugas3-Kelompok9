using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Module.Message;

namespace SpaceInvader.Module.BulletPlayer
{
    public class BulletPlayerController : ObjectController<BulletPlayerController, BulletPlayerModel, IBulletPlayerModel, BulletPlayerView>
    {
        public void OnShootBulletPlayer(PlayerBulletShootMessage message)
        {
            Debug.Log("Shooting");
        }
    }
}