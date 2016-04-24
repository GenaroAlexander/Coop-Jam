using UnityEngine;
using System.Collections;

public class TriggerScript1 : MonoBehaviour {

    public BarrierScript1 barrier1, barrier2;
    public BarrierScript2 topBarr;

   public bool triggered;

	// Use this for initialization
	void Start () {
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter()
    {
        if (!triggered)
        {
            triggered = true;

            barrier1.move = true;
            barrier2.move = true;
            topBarr.move = true;
            // Vector3

            // barrier1.transform
        }
    }
}
