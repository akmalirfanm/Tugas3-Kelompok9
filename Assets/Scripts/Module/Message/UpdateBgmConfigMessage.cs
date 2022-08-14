using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kelompok9.SpaceInvader.Message
{
    public struct UpdateBgmMessage
    {
        public int Bgm { get; private set; }

        public UpdateBgmMessage(int bgm)
        {
            Bgm = bgm;
        }
    }
}
