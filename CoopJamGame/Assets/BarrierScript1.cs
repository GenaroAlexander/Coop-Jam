using UnityEngine;
using System.Collections;

public class BarrierScript1 : MonoBehaviour {

    public bool move;

    public Vector3 endPos;

	// Use this for initialization
	void Start () {
        move = false;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(move)
        {
            //transform.position += 

            Vector3 phPos = endPos - transform.position;
            transform.position += phPos * Time.deltaTime;

            transform.Rotate(new Vector3(0, 0, 1), -90 * Time.deltaTime);

            if (Vector3.Distance(transform.position, endPos) < 6)
                move = false;
        }

	}

    
}
