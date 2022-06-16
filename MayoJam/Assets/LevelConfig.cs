using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="EnemySpawnConfig")]
public class LevelConfig :ScriptableObject
{
    public int enemyAmount = 4;
    public Vector3[] spawnPoints;
    public Enemy[] prefab;
}
