using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    [SerializeField] private float speed = 10f;

    [SerializeField] private float sideMovenmentSpeed = 7f;

    [SerializeField] private Animator playerAnimator;


    private Transform tr;

    [SerializeField] private bool isGameStarted = false;
    
    void Start()
    {
        this.tr = transform;
    }

    
    void Update()
    {
        if (isGameStarted){
            float horizontalMovenment = Input.GetAxis("Horizontal");
            this.tr.position += this.tr.forward * speed * Time.deltaTime;
            this.tr.Translate(horizontalMovenment * Time.deltaTime * sideMovenmentSpeed, 0, 0); 
         }
       
	}

}
