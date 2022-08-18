using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;

namespace SpaceInvader.Module.Bullet
{
    public class BulletPoolView : ObjectView<IBulletPoolModel>
    {
        GameObject firstActiveGameObject;
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
            return enemy;
        }

        public void Update()
        {
            if (waktu >= 0)
            {
                waktu -= Time.deltaTime;
            }
            else
            { 

                waktu = 5;

            }
        }

        public GameObject PoolBullet(GameObject bullet)
        {
            for (int i = 0; i <= transform.GetChildCount(); i++)
            {
                if (!transform.GetChild(i).gameObject.activeInHierarchy)
                {
                    SpawnBullet(bullet);
                }
                
            }
            return null;
        }


    }
}
