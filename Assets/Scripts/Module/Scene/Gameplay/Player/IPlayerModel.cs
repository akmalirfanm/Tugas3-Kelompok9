using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.PlayerController
{
    public interface IPlayerModel : IBaseModel
    {
        public Vector3 Position { get; }
        public Vector3 Direction { get; }
        public float speed { get; }


    }
}
