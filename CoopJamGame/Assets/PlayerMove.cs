using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


    public float speed;

    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHoriz = Input.GetAxis("Horizontal");

        rb.AddForce(new Vector3(moveHoriz, 0, 0) * speed);
	}
}
