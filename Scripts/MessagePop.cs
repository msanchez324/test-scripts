using UnityEngine;

public class MessagePop : MonoBehaviour
{
    public GameObject msg;

    public Transform msgLookAt;
    private Transform msgPosition;
    // Collider GetCollider() { return player.GetComponent<Collider>(); }

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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.tag== "Player")
        {
            Debug.Log("entro al if"); msg.SetActive(true);
        }
          
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            msg.SetActive(false);
    }

   
}
