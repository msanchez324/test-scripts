using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class NPCPatrol : MonoBehaviour
{
    private CharacterController characterController;

    public float movSpeed;  //NPC movement Speed
    public Transform[] waypoints;   //
    private int currentWaypointIndex = 0;   //
    public bool temp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
        Debug.Log(temp);
         temp = pos(temp);
    }

    bool pos(bool temp)
    {
        // el punto actual en el qu se encuentra
        if (transform.position == waypoints[currentWaypointIndex].position)
            increaseCurrentWaypointIndex();
        if (temp == true)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                waypoints[currentWaypointIndex].position,
                movSpeed * Time.deltaTime);
            //Hacia donde mirara el NPC
            transform.LookAt(waypoints[currentWaypointIndex].position);
        }

        if (transform.position == waypoints[currentWaypointIndex].position)
            temp = false;
        return temp;
    }

    void increaseCurrentWaypointIndex()
    {
        currentWaypointIndex++;
        if(currentWaypointIndex >= waypoints.Length)
            currentWaypointIndex = 0;
    }
}
