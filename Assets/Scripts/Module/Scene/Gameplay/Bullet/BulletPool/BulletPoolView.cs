using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Bullet
{
    public class BulletPoolView : ObjectView<IBulletPoolModel>
    {
        float waktu = 5;
        protected override void InitRenderModel(IBulletPoolModel model)
        {

        }

        protected override void UpdateRenderModel(IBulletPoolModel model)
        {

        }

        public GameObject SpawnBullet(GameObject gameObject)
        {
            GameObject enemy = Instantiate(gameObject,transform);
            enemy.AddComponent<BoxCollider2D>();
            return enemy;
        }

        public void Update()
        {
            if (waktu >= 0)
            {
                waktu -= Time.deltaTime;
            }
            else
            { }
        }

    }
}
