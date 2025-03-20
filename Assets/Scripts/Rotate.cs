using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torque;
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
        }
        else if(Input.GetKeyDown(KeyCode.A)) 
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
