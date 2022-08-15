using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Module.PlayerController
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, PlayerView, IPlayerModel>
    {
        public void OnPlayerMovement(PlayerMoveMessage message)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
            }
        }
    }
}
