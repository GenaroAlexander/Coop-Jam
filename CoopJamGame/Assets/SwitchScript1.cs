using UnityEngine;
using System.Collections;

public class SwitchScript1 : MonoBehaviour {

    public GameObject barr1, barr2, barr3;

    bool triggered;

	// Use this for initialization
	void Start () {
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter()
    {
        if(!triggered)
        {
            triggered = true;

            barr1.SetActive(false);
            barr2.SetActive(false);
            barr3.SetActive(false);
        }
    }
}
