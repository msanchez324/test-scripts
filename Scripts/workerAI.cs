using System;
using UnityEngine;
using UnityEngine.AI;

public class WorkerAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1)
        {


            NextTask();
           // IterateWaypointIndex();
           // UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
            waypointIndex = 0;
    }

    void TaskSelection()
    {
        if ( target == waypoints[0].position)
        {

        }
            
    }

    void NextTask()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }
}