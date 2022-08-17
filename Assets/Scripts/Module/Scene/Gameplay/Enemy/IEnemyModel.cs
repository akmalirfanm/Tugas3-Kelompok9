using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;


namespace SpaceInvader.Module.enemy
{
    public interface IEnemyModel : IBaseModel
    {
        //public bool IsPlaying { get; }
        //public Vector3 SpawnPoint { get; }
        //public Vector3 Position { get; }
        //public Vector3 DespawnPosition { get; }
        public Vector2 walkAmount { get; }
        public float walkDirection { get; }
        public float originalX { get; }
    }
}


