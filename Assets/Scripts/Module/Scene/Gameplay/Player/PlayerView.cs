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
        private UnityAction _movekanan;
        private UnityAction _movekiri;

        public void SetCallbacks(UnityAction movekanan, UnityAction movekiri)
        {
            _movekanan = movekanan;
            _movekiri = movekiri;

        }

        protected override void InitRenderModel(IPlayerModel model)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>($"Sprites/ship4")[0]; ;
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>($"Sprites/ship4")[0]; ;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _movekanan.Invoke();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _movekiri.Invoke();
            }
        }

    }
}
