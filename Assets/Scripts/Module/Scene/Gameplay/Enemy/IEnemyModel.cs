using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;


namespace SpaceInvader.Module.Enemy
{
    public interface IEnemyModel : IBaseModel
    {
        public Vector3 Position { get; }
        public Vector2 walkAmount { get; }
        public float walkDirection { get; }
        public float originalX { get; }
        public float currentX { get; }
    }
}


