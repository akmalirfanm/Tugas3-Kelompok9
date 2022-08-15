using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceInvader.Module.PlayerController
{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public float speed = 2f;
        public Vector2 Position { get; private set; } 

    }
}
