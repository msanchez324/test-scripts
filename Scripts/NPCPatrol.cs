using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NPCPatrol : MonoBehaviour
{
    public float movSpeed;
    public Transform[] waypoints;
    private int currentWaypointIndex = 0;
    //private float minDistance;
    //private int randomNumber;
    //private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        // el punto actual en el qu se encuentra
        Transform waypoint = waypoints[currentWaypointIndex];
        if (Vector3.Distance(transform.position, waypoint.position) < 0.01f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                waypoint.position,
                movSpeed * Time.deltaTime);
            //Hacia donde mirara el NPC
            transform.LookAt(waypoint.position);
        }
    }
}
