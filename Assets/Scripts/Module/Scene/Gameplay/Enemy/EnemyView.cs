using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine.Events;

namespace SpaceInvader.Module.enemy { 
public class EnemyView : ObjectView<IEnemyModel>
    {
        private UnityAction _onMovePosition;
        private UnityAction _onDespawnObstacle;

        public void SetCallbacks(UnityAction onMovePosition, UnityAction onDespawnObstacle)
        {
            _onMovePosition = onMovePosition;
            _onDespawnObstacle = onDespawnObstacle;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            transform.position = _model.Position;
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            transform.position = _model.Position;
        }

        private void Update()
        {
            _onMovePosition?.Invoke();
            _onDespawnObstacle?.Invoke();
        }
    }
}