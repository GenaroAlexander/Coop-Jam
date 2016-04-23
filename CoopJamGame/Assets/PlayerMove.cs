using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


    public float speed;

    public int MinionID;

   // public int currMin;

    public GameData gamestats;

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
      //  currMin = gamestats.currentMinion;
        // MOVE CODE
        if(gamestats.currentMinion == MinionID)
        {
            velocity = rb.velocity;
            float moveHoriz = Input.GetAxis("Horizontal");
            float moveVert = Input.GetAxis("Vertical");

            float jump = 0;

            if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(velocity.y) < 2)
            {
                jump = 50;
            }
            rb.AddForce(new Vector3(moveHoriz, jump, moveVert * 0.5f) * speed);
        }
      
    }
}
