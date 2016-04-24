using UnityEngine;
using System.Collections;

public class MovingWallTriigers : MonoBehaviour {

	public GameObject wallPart1;
	public GameObject wallPart2;
	public GameObject wallPart3;

	public bool triggered;
	// Use this for initialization
	void Start () {
		triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnTriggerEnter(){

			if (!triggered) {
				triggered = true;

				wallPart1.SetActive(false);
				wallPart2.SetActive(false);
				wallPart3.SetActive(false);
			}
	}
}
