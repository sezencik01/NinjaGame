using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{


    [SerializeField] private GameObject startScreen;
    
    [SerializeField] private GameObject endScreen;

    [SerializeField] private Player player;

    void Start()
    {
        endScreen.SetActive(false);
    }

   
    public void StartGame(){
        startScreen.SetActive(false);
	player.isGameStarted = true;
    }
        

    public void EndGame(){
        
        endScreen.SetActive(true);
    
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}

