using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
//using SpaceInvader.Message;

namespace SpaceInvader.Module.enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {

        //public override IEnumerator Initialize()
        //{
        //    yield return base.Initialize();
        //    SetInitPosition();
        //}

        //public override void SetView(EnemyView view)
        //{
        //    base.SetView(view);
        //    InitPoolObject();
        //}

        //public void OnStartPlay(StartPlayMessage message)
        //{
        //    _model.SetIsPlaying(true);
        //    _view.SetCallbacks(OnMovePosition, OnDespawnObstacle);
        //}

        //public void OnGameOver(GameOverMessage message)
        //{
        //    _model.SetIsPlaying(false);
        //}

        //private void SetInitPosition()
        //{
        //    Vector3 worldPointPosition = Camera.main.ViewportToWorldPoint(_model.Position);
        //    _model.SetPosition(worldPointPosition);
        //    Vector3 worldPointDespawnPosition = Camera.main.ViewportToWorldPoint(_model.DespawnPosition);
        //    _model.SetDespawnPosition(worldPointDespawnPosition);
        //}

        //private void InitPoolObject()
        //{
        //    for (int i = 0; i < _model.PoolSize; i++)
        //    {
        //        GameObject obstaclePrefab = Resources.Load<GameObject>(@"Prefabs/Obstacle/Obstacle");
        //        GameObject obstacle = Object.Instantiate(obstaclePrefab, _view.transform);
        //        SpawnObstacle(obstacle);
        //    }
        //}

        //private void SpawnObstacle(GameObject obstacle)
        //{
        //    Vector3 obstacleYPosition = Vector3.up * Random.Range(_model.MinYSpawnPoint, _model.MaxYSpawnPoint);
        //    obstacle.transform.localPosition = _model.SpawnPoint + obstacleYPosition;
        //    _model.MoveSpawnPoint();
        //    obstacle.SetActive(true);
        //    _model.EnqueueObstacle(obstacle);
        //}

        //private void OnMovePosition()
        //{
        //    if (_model.IsPlaying)
        //    {
        //        Vector3 position = _model.Position + (Vector3.left * _model.ScrollSpeed * Time.deltaTime);
        //        _model.SetPosition(position);
        //    }
        //}

        //private void OnDespawnObstacle()
        //{
        //    float frontObstaclePosition = _model.GetObstacleInFront().transform.position.x;
        //    float despawnPosition = _model.DespawnPosition.x;
        //    if (frontObstaclePosition <= despawnPosition)
        //    {
        //        GameObject obstacle = _model.DequeueObstacle();
        //        obstacle.SetActive(false);
        //        SpawnObstacle(obstacle);
        //    }
        //}
        public void MoveEnemy()
        {
            Debug.Log("move");

            _model.walkAmount = new Vector2(_model.walkDirection * 0.5f * Time.deltaTime, 0);

            if (_model.walkDirection > 0.0f && _view.transform.position.x >= _model.originalX + 0.5)
            {
                _model.walkDirection = -1.0f;
                _view.transform.position = new Vector3(_view.transform.position.x,
                    _view.transform.position.y - 1, _view.transform.position.z);
            }
            else if (_model.walkDirection < 0.0f && _view.transform.transform.position.x <= _model.originalX - 0.75)
            {
                _model.walkDirection = 1.0f;
                _view.transform.position = new Vector3(_view.transform.position.x,
                    _view.transform.position.y - 1, _view.transform.position.z);
            }

            _view.transform.Translate(_model.walkAmount);
        }

        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            view.SetCallback(MoveEnemy);
        }

        public void Init(EnemyModel model, EnemyView view)
        {
            _model = model;
            SetView(view);
        }
    }

}
