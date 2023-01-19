using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    [SerializeField] private GameObject startScreen;
    
    [SerializeField] private GameObject endScreen;


    void Start()
    {
        endScreen.SetActive(false);
    }

   
    public void StartGame(){
        Debug.Log("Oyun Başladı");
    }
        
}

