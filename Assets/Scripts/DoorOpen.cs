using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorOpen : MonoBehaviour
{
    playerControl playerScript; 

    // Allows Interaction between DOOR and PLAYER
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<playerControl>();
    }

    //Allows Player to OPEN door with KEY "destroyed"
    void OnMouseDown()
    {
        if(playerScript.hasKey == true)
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        
    }
}
