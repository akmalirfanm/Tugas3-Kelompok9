using Agate.MVC.Base;
using Agate.MVC.Core;
using Kelompok9.SpaceInvader.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Module.PlayerController;
using SpaceInvader.Module.Input;

namespace Kelompok9.SpaceInvader.Gameplay
{
	public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
	{
        private PlayerController _PlayerController;
        public override string SceneName => "Gameplay";
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new PlayerController(),
                new InputController(),
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _PlayerController.SetView(_view.PlayerView);
            yield return null;

        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

    }
}
