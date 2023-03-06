using UnityEngine;
using UnityEngine.AI;

public class WorkerAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    int i;
    Vector3 target;
    public GameObject[] msg;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1)
        {

            
            NextTask();
           // TaskSelection();
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
        i++;
        if (i == msg.Length)
            i =0;
        
        if (agent.transform.position == waypoints[i].position)
        {
            msg[i].SetActive(true);
        }
        else
        {
            msg[i].SetActive(false);
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