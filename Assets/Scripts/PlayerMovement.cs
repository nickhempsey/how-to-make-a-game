using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 1f;
    public float deathDistance = -1f;
    

    // Change this to "FixedUpdate becasue we are using it to change physics.
    void FixedUpdate()
    {

        Debug.Log(rb.position.y);

        // Add forward force
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space") && rb.position.y == 0)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < deathDistance)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
