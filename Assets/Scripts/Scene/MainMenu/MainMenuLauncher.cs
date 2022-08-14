using Agate.MVC.Base;
using Agate.MVC.Core;
using Kelompok9.SpaceInvader.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kelompok9.SpaceInvader.Home
{ 
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
{
        public override string SceneName => "Home";

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
            _view.SetCallbacks(OnClickPlayButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }
    }
}
