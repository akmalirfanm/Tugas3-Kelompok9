using Agate.MVC.Base;
using Agate.MVC.Core;
using Kelompok9.SpaceInvader.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Module.PlayerController;
using SpaceInvader.Module.Input;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.Bullet;

namespace Kelompok9.SpaceInvader.Gameplay
{
	public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
	{
        private PlayerController _PlayerController;
        private EnemySpawnerController _enemySpawnerController;
        private BulletPoolController _bulletPoolController;
        public override string SceneName => "Gameplay";
        protected override IConnector[] GetSceneConnectors()
        {

            return new IConnector[] {
                new PlayerConnector(),
                new EnemySpawnerConnector()
            };

        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new PlayerController(),
                new InputController(),
                new EnemySpawnerController(),
                new BulletPoolController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _PlayerController.SetView(_view.PlayerView);
            _enemySpawnerController.SetView(_view.EnemySpawnerView);
            //_bulletPoolController.SetView(_view.BulletPoolView);
            yield return null;

        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

    }
}
