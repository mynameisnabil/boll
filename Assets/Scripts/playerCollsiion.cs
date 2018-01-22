using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollsiion : MonoBehaviour
{

    public Rigidbody rb;
    public float flyForce = 5000f;

    // Update is called once per frame
    void OnCollisionEnter(Collision info)
    {

        if (info.collider.tag == "flyTrigger")
        {
            rb.AddForce(0, flyForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (info.collider.tag == "resetLevel")
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            FindObjectOfType<GameManager>().gameOver();


            
        }

        if (info.collider.tag == "nextLevel")
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            FindObjectOfType<GameManager>().nextLevel();

        }
    }
}
