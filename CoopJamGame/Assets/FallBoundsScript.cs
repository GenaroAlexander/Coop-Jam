using UnityEngine;
using System.Collections;

public class FallBoundsScript : MonoBehaviour {


    public Vector3 resetPos;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other)
    {
        other.transform.position = resetPos;
    }
	
}
