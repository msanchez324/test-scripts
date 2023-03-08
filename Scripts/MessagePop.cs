using UnityEngine;

public class MessagePop : MonoBehaviour
{
    public GameObject msg;      //Message Game Object variable
    public Transform msgLookAt;     //Variable where msg will be looking at.
    private Transform msgPosition;      //

    // Start is called before the first frame update
    void Start()
    {
        msgPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (msgLookAt)
        {
            msgPosition.LookAt (2 * msgPosition.position - msgLookAt.position);
        }
    }

    //Detect when the collider enter the triggers
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player"))
            msg.SetActive(true);
          
    }

    //Detect when the collider exit the triggers
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player"))
            msg.SetActive(false);
    }

   
}
