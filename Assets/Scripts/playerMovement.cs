using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;

	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if (rb.position.y < -0.5)
        {
            FindObjectOfType<GameManager>().gameOver();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            FindObjectOfType<GameManager>().previousLevel();
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            FindObjectOfType<GameManager>().resetLevel();
        }
    }
}
