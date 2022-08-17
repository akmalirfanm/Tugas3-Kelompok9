using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Module.PlayerController;
using SpaceInvader.Module.Enemy;

namespace Kelompok9.SpaceInvader.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField]
		public PlayerView PlayerView;

        [SerializeField] EnemySpawnerView enemySpawnerView;
		public EnemySpawnerView EnemySpawnerView => enemySpawnerView;
	}
}
