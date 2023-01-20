using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesDestroy : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Coin"))
        {
            UIScore.Instance.ScoreInCrease();
            Destroy(col.gameObject);
            
        }
    }
}