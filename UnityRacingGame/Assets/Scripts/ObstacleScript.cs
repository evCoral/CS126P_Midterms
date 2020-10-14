using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour{
    public Vector3 waypoint1, waypoint2;
    public bool up = false;
    void Start()
    {
        waypoint1 = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
        waypoint2 = new Vector3(transform.position.x, transform.position.y - 3, transform.position.z);
    }

    void Update(){
        if (!up) transform.position = Vector3.MoveTowards(transform.position, waypoint1, 1F * Time.deltaTime);
        else transform.position = Vector3.MoveTowards(transform.position, waypoint2, 1F * Time.deltaTime);
        if (transform.position.y > 3) up = true;
        else if (transform.position.y < -1) up = false;
    }
}
