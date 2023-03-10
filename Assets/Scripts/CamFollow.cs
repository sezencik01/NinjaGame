using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{


    private Transform tr;


    [SerializeField] private Transform playerObject;
    
    [SerializeField] private Vector3 camOffset;

    public float camOffsetZ{
        set{
            this.camOffset.z = value;  
	    }
    }


    
    void Start()
    {
        this.tr = transform;
    }

    
    void LateUpdate()
    {
        this.tr.position = playerObject.position + camOffset;  
    }
}
