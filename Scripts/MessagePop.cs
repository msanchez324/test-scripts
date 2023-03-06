using UnityEngine;

public class MessagePop : MonoBehaviour
{
    public GameObject msg;
    // Collider GetCollider() { return player.GetComponent<Collider>(); }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("entro al if"); msg.SetActive(true);
        }
          
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            msg.SetActive(false);
    }

   
}
