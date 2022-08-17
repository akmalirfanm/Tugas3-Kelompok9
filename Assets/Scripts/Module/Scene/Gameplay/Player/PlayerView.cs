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
        private float speed;

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
            speed = model.speed;
        }

        private void Update()
        {
            float _x = transform.position.x + direction.x;
            if (_x <= -8 || _x >= 8) return;
            transform.Translate(direction * Time.deltaTime * speed);


            //if (transform.position.x <= 7.486 && transform.position.x >= -7.486)
            //{

            //    transform.Translate(direction * Time.deltaTime * speed);
            //}
            //else if (transform.position.x <= -6.4)
            //{ transform.position = new Vector3(-7.485f, transform.position.y); }
            //else if (transform.position.x >= 6.4 )
            //{ transform.position = new Vector3(7.485f, transform.position.y); }

        }

    }
}
