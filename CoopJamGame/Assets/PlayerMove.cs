using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


    public float speed;

    public int MinionID;

    public float MaxDist;

   // public int currMin;
    public GameObject partner;

    public GameData gamestats;

    public Vector3 velocity;

    private Rigidbody rb;

    public bool dontMove;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        dontMove = false;
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

            if (Input.GetKeyDown(KeyCode.C))
                dontMove = !dontMove;
        }
        else
        {
            float dist = Vector3.Distance( transform.position, partner.transform.position);

            if(dist > MaxDist && !dontMove)
            {
                if (transform.position.x > partner.transform.position.x)
                    rb.AddForce(-speed, 0, 0);
                else
                    rb.AddForce(speed, 0, 0);
            }
        }
      
    }
}
