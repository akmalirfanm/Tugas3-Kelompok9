using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine.Events;

namespace SpaceInvader.Module.enemy { 
public class EnemyView : ObjectView<IEnemyModel>
    {
        public float originalX { get; private set; }
        private UnityAction _onMove;

        public void SetCallback(UnityAction OnMove)
        {
            _onMove = OnMove;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            originalX = transform.position.x;
            Debug.Log(originalX);
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {

        }

        private void Start()
        {

        }

        private void Update()
        {
            _onMove.Invoke();
        }
        //private UnityAction _onMovePosition;
        //private UnityAction _onDespawnObstacle;

        //public void SetCallbacks(UnityAction onMovePosition, UnityAction onDespawnObstacle)
        //{
        //    _onMovePosition = onMovePosition;
        //    _onDespawnObstacle = onDespawnObstacle;
        //}

        //protected override void InitRenderModel(IEnemyModel model)
        //{
        //    transform.position = _model.Position;
        //}

        //protected override void UpdateRenderModel(IEnemyModel model)
        //{
        //    transform.position = _model.Position;
        //}

        //private void Update()
        //{
        //    _onMovePosition?.Invoke();
        //    _onDespawnObstacle?.Invoke();
        //}
    }
}