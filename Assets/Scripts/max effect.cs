using UnityEngine;

public class maxeffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kick();
        }
            ApplyMaxEffect();
           
    }
    void kick()
    {
     rb.linearVelocity = velocity;
     rb.angularVelocity = spin;
    }
    void ApplyMaxEffect() 
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity);
        rb.AddForce(magnusForce,ForceMode.Force);
    }
}
