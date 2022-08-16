using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Message;
using System;

namespace SpaceInvader.Module.PlayerController
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    {


        public void Onmove(int x)
        {
            Vector3 dir = new Vector3(x,0,0);
            _model.Setdirection(dir);
        }

       

        /*public override void SetView(PlayerView view)
        {
            base.SetView(view);
            view.SetCallbacks(movekanan, movekiri);
        }*/
    }
}
