using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


    public float speed;

    public Vector3 velocity;

    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        velocity = rb.velocity;
        float moveHoriz = Input.GetAxis("Horizontal");


        float jump = 0;

        if (Input.GetKeyDown(KeyCode.Space) && velocity.y == 0)
        {
            jump = 20;
        }
        rb.AddForce(new Vector3(moveHoriz, jump, 0) * speed);
    }
}
