using Agate.MVC.Base;
using Agate.MVC.Core;
using Kelompok9.SpaceInvader.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kelompok9.SpaceInvader.Gameplay
{
	public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
	{
        public override string SceneName => "Gameplay";
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

    }
}
