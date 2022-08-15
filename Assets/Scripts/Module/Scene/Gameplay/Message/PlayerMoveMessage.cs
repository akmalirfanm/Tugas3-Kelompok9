using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct PlayerMove
    {
        public int X { get; private set; }

        public PlayerMove(int x)
        {
            X = x;
        }
    }
}
