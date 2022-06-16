using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYLevelBuilder : MonoBehaviour
{
    public LevelConfig level1;
    public Enemy[] enemyList;
    public Transform parent;

  public void Start()
    {
        for (int i = 0; i < level1.enemyAmount; i++)
        {
            enemyList[i] = Instantiate(level1.prefab[Random.Range(0,level1.prefab.Length)], parent);
            enemyList[i].gameObject.transform.position = level1.spawnPoints[i];
        }
    }
}
