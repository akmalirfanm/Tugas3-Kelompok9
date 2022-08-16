using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using SpaceInvader.Message;
using System;

namespace SpaceInvader.Module.PlayerController
{
    public class PlayerView : ObjectView<IPlayerModel>
    {
        //private UnityAction _move ;
        private Vector3 direction;

        //public void SetCallbacks(UnityAction Move,int i)
        //{
        //    _move = Move;


        //}

        protected override void InitRenderModel(IPlayerModel model)
        {
            transform.position = _model.Position;
            GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>($"Sprites/player1")[0]; ;
            direction = Vector3.zero;
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {

            GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>($"Sprites/player1")[0];
            direction = model.Direction;
        }

        private void Update()
        {

            transform.Translate(direction *Time.deltaTime);

        }

    }
}
