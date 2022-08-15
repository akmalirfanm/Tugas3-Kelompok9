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

        public void movekanan() 
        {
            _view.transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }

        public void movekiri()
        {
            _view.transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }

        public override void SetView(PlayerView view)
        {
            base.SetView(view);
            view.SetCallbacks(movekanan, movekiri);
        }
    }
}
