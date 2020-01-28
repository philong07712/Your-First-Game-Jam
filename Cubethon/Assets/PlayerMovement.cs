using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidB;
    public float force = 2000f;
    public float sideWayForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rigidB.AddForce(0, 0, force * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rigidB.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rigidB.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rigidB.AddForce(0, 0, -force * Time.deltaTime);
        }
    }
}
