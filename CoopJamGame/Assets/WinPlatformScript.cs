using UnityEngine;
using System.Collections;

public class WinPlatformScript : MonoBehaviour {


    public bool Triggered;

    public string ID;

	// Use this for initialization
	void Start () {
        Triggered = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ID && Triggered == false)
        {

            Triggered = true;
        }
    }
}
