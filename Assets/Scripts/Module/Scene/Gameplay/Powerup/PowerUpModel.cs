//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Agate.MVC.Base;
//using Agate.MVC.Core;

//public class PowerUpModel : BaseModel, IPowerUpModel
//{
//    public float SpeedPU { get; set; } //= 3f;

//    public Vector3 PowerUpPosition { get; set; } = new Vector3();

//    public Vector3 spawnAreaMax { get; set; } = new Vector3(8, 6, 0);
//    public Vector3 spawnAreaMin { get; set; } = new Vector3(-8, 6, 0);

//    public PowerUpModel()
//    {
//        SpeedPU = 1f;
//    }

//    public void SetPUPosition(Vector3 position)
//    {
//        PowerUpPosition = position;
//        SetDataAsDirty();
//    }
//}