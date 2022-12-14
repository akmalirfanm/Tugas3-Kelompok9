using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Module.Enemy;
using System;
using SpaceInvader.Message;

namespace SpaceInvader.Module.Bullet
{
    public class BulletPoolController : ObjectController<BulletPoolController, BulletPoolModel, IBulletPoolModel, BulletPoolView>
    {
        EnemyController enemyControl;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetPosition(enemyControl.Model.Position);
        }
        public void InitBulletPool()
        {
            BulletModel instanceModel = new BulletModel();
            GameObject bullet = _view.SpawnBullet(_model.enemyScriptableObject.enemyObject);
            bullet.AddComponent<BoxCollider2D>();
            bullet.AddComponent<BulletView>();
            bullet.transform.localScale = bullet.transform.localScale * .1f;
            SpawnBullet(bullet);

            //BulletView instanceView = bullet.AddComponent<BulletView>();

            BulletController instance = new BulletController();


            //InjectDependencies(instance);
            //instance.Init(instanceModel, instanceView);

            bullet.SetActive(false);
        }

        public override void SetView(BulletPoolView view)
        {
            base.SetView(view);
            InitBulletPool();
        }


        public void InitPoolBullet(StartPlayMessage message)
        {
            SpawnBulletPool();

        }

        public void SpawnBulletPool()
        {
            GameObject bulletPool = PoolBullet();
            if (bulletPool != null)
            {
                bulletPool.SetActive(true);
                Debug.Log("SpawnBulletPool");
            }
        }

        public GameObject PoolBullet()
        {
            for (int i = 0; i < _model.maxBullet; i++)
            {
                if (!_model.pooledBullets[i].activeInHierarchy)
                {
                    //_model.bulletCtrs[i].BulletPosition();
                    Debug.Log("PoolBullet");
                    return _model.pooledBullets[i];
                }
            }
            return null;
        }



        private void SpawnBullet(GameObject bullet)
        {
            bullet.transform.position = enemyControl.Model.Position;
            _model.AddBullet(bullet);
            bullet.SetActive(true);
        }
    }
}