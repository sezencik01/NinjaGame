using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    [SerializeField] private GameManager manager; 

   
    [SerializeField] private float speed = 10f;

    
    [SerializeField] private float sideMovenmentSpeed = 7f;

    
    [SerializeField] private Animator playerAnimator;

   
    [SerializeField] private CamFollow camFollow;

    [SerializeField] private GameObject kazandın;

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AudioClip audioClip;


    
    private Transform tr;


    
    [SerializeField] public bool isGameStarted = false;

    
    
    void Start()
    {
        this.tr = transform;
    }


    void Update()
    {
        if (isGameStarted)
        {
            this.playerAnimator.SetBool("isRunning", true);
            float horizontalMovenment = Input.GetAxis("Horizontal");
            this.tr.position += this.tr.forward * speed * Time.deltaTime;
            this.tr.Translate(horizontalMovenment * Time.deltaTime * sideMovenmentSpeed, 0, 0);
        }
    }



    private void OnTriggerEnter(Collider other){
        if(other.tag == "Finish"){
            this.playerAnimator.SetBool("isDancing", true);
            this.isGameStarted = false;
            kazandın.SetActive(true);
            audioSource.PlayOneShot(audioClip);


        }
        if(other.tag == "Obstacle"){
            manager.EndGame();
            this.isGameStarted = false;
            this.camFollow.camOffsetZ = -7;
            this.playerAnimator.SetBool("isFall", true);
        }

    }
    
}