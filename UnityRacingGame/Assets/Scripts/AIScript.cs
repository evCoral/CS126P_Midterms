using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour{
    public Vector3 spawnPoint;
    public bool dead = false;
    public Transform waypoint;
    public float landmark;
    public Vector3 movement;


    void Start(){
        spawnPoint = transform.position;
        landmark = waypoint.position.x;
    }

    public void AI(){
        movement.z = Mathf.Min(3,movement.z+1F*Time.deltaTime);
        if (transform.position.x > landmark) movement.x = (Mathf.Max(-3,movement.x-1F*Time.deltaTime));
        else if (transform.position.x < landmark) movement.x = (Mathf.Min(3,movement.x+1F*Time.deltaTime));
        transform.position += movement * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), .2F);
    }

    public void Respawn(){
        transform.rotation = Quaternion.Euler(0,0,0);
        transform.position = spawnPoint;
        dead = false;
    }

    void Update(){
        if (!dead){
            AI();
            // CarStatus();
        }
        else{
            Respawn();
        }
    }
}