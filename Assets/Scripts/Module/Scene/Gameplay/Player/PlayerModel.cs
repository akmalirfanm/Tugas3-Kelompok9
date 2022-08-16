using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceInvader.Module.PlayerController
{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public bool Move { get; private set; } 
        public Vector3 Position { get; private set; } = new Vector3(0, -4f);

        public bool IsPlaying { get; private set; } = false;
        public float ScrollSpeed { get; private set; } = 1f;
        public float SpawnGap { get; private set; } = 4f;
        public float MinYSpawnPoint { get; private set; } = 3.2f;
        public float MaxYSpawnPoint { get; private set; } = -0.7f;
        public Vector3 DespawnPosition { get; private set; } = new Vector3(-.2f, 0.5f, 10f);

        public Vector3 Direction { get; private set; }

        private Queue<GameObject> ObstaclePool = new Queue<GameObject>();

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }

        public void SetPosition(Vector3 position)
        {
            Position = position;
            SetDataAsDirty();
        }

        public void setmoving(bool move)
        {
            Move = move;
            SetDataAsDirty();
        }

        public void SetDespawnPosition(Vector3 despawnPosition)
        {
            DespawnPosition = despawnPosition;
            SetDataAsDirty();
        }

        public void Setdirection(Vector3 direction)
        {
            Direction = direction;
            SetDataAsDirty();
        }
    }
}
