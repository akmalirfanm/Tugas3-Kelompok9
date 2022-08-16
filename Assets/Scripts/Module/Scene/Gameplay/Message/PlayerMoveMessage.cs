using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct PlayerMoveMessage
    {
        public int X { get; private set; }

        public PlayerMoveMessage(int x)
        {
            X = x;
        }
    }
}
