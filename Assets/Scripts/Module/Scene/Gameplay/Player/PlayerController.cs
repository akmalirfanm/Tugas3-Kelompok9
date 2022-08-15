using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.PlayerController
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    {
        public void OnPlayerMovement(PlayerMoveMessage message)
        {

        }


        public void move(int x) 
        {
            _view.transform.Translate(new Vector3(x * Time.deltaTime, 0, 0));
        }



        /*public override void SetView(PlayerView view)
        {
            base.SetView(view);
            view.SetCallbacks(movekanan, movekiri);
        }*/
    }
}
