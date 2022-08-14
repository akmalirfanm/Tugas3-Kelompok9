using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kelompok9.SpaceInvader.Message
{
    public struct UpdateSfxMessage
    {
        public int Sfx { get; private set; }

        public UpdateSfxMessage(int sfx)
        {
            Sfx = sfx;
        }
    }
}