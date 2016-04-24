using UnityEngine;
using System.Collections;

public class BarrierScript2 : MonoBehaviour {

	// Use this for initialization

    public bool move;

    float rotVal;

	void Start () {
        move = false;
        rotVal = 90;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(move)
        {
            float rotAmt = 90 * Time.deltaTime;
            rotVal -= rotAmt;
            transform.Rotate(new Vector3(0, 0, 1), rotAmt);

            if (rotVal <= 0)
                move = false;
        }

	}
}
