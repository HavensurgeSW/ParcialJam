using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameEvents : MonoBehaviour
{

    public CoinBehaviour[] coins;
    public TMP_Text scoreText;
    private int score;
    public ParticleSystem bloodSpat;

    public static GameEvents current;
    public static Action<Enemy> OnEnemyKilled;
    
    //public event Func<int,int, bool> ReturnCringe;
    
    private void Awake(){
        current = this;
        for (int i = 0; i < coins.Length; i++)
        {
            coins[i].Init(TriggerScoreUI);
        }
        
    }

    void OnEnable()
    {
        OnEnemyKilled += CreateBloodSpatter;
        OnEnemyKilled += KillEnemy;
    }
    void OnDisable()
    {
        OnEnemyKilled -= CreateBloodSpatter;
        OnEnemyKilled -= KillEnemy;
    }

    private void KillEnemy(Enemy e) {
        e.gameObject.SetActive(false);
    }

    private void CreateBloodSpatter(Enemy e) {
        Instantiate(bloodSpat, e.transform.position, Quaternion.Euler(-90,0,0));

    }

    private void TriggerScoreUI() {
        score++;
        scoreText.text = "Score: " + score;
    }


}
