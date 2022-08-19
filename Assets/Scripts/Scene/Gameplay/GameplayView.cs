using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Module.PlayerController;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.Bullet;
using SpaceInvader.Module.Audio;
using SpaceInvader.Module.Enemy;

namespace Kelompok9.SpaceInvader.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField]
		public PlayerView PlayerView;

        [SerializeField] EnemySpawnerView enemySpawnerView;
		public EnemySpawnerView EnemySpawnerView => enemySpawnerView;
		
		[SerializeField] BulletPoolView bulletPoolView;
        public BulletPoolView BulletPoolView => bulletPoolView;

		[SerializeField] AudioView audioView;
		public AudioView AudioView => audioView;

		[SerializeField] EnemyView enemyView;
		public EnemyView EnemyView => enemyView;
		
		[SerializeField] BulletView bulletView;
		public BulletView BulletView => bulletView;

	}
}
