﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(collisionInfo.collider.name);
            playerMove.enabled = false;
        }
    }
}
