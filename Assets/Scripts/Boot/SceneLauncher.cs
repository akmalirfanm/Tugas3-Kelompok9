using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kelompok9.SpaceInvader.Boot
{
	public abstract class SceneLauncher<TLauncher, TView> : BaseLauncher<TLauncher, TView>
	where TLauncher : SceneLauncher<TLauncher, TView>
	where TView : BaseSceneView
	{

	}
}
