using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    Action OnCoinGrabbed;
    

    public void Init(Action onCoinGrabbed) {
        OnCoinGrabbed += onCoinGrabbed;
    }



    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")) {
            OnCoinGrabbed?.Invoke();
            Destroy(gameObject);
        }  
    }

}
