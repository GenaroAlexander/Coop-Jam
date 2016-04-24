using UnityEngine;
using System.Collections;

public class BarrierScript1 : MonoBehaviour {
	float rotationval;
	public bool move;
    public Vector3 endPos;

	// Use this for initialization
	void Start () {
        move = false;
		rotationval = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(move)
        {
            //transform.position += 
			rotationval += 90 * Time.deltaTime * 2;
            Vector3 phPos = endPos - transform.position;
            transform.position += phPos * Time.deltaTime *2;

			if (rotationval < 90) {
				transform.Rotate (new Vector3 (0, 0, 1), -90 * Time.deltaTime * 2);
			}
            if (Vector3.Distance(transform.position, endPos) < 6)
                move = false;
        }

	}

    
}
