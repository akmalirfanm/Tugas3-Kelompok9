using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Bunker
{
    public class BunkerView : ObjectView<IBunkerModel>
    {


        protected override void InitRenderModel(IBunkerModel model)
        {
            //throw new System.NotImplementedException();
        }

        protected override void UpdateRenderModel(IBunkerModel model)
        {
            //throw new System.NotImplementedException();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("BulletEnemy"))
            {
                GetComponent<BoxCollider2D>().enabled = false;
                gameObject.SetActive(false);
            }
        }
    }
}