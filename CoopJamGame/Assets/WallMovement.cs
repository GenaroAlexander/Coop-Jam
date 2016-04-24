using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour {

	public GameObject Wall1;
	public GameObject Wall2;
	public GameObject Wall3;
	public GameObject Trigger;

	float length;
	float lifetime;
	float speed;

	void Start(){
		length = 5;
		speed = 10;
		lifetime = 0;
	}
	void Update()
	{
		lifetime += Time.deltaTime;
		if (lifetime >= length) {
			lifetime = 0;
			speed *= -1;
		}

		Vector3 Poshelp = Wall1.transform.position;
		Poshelp.x += speed * Time.deltaTime;
		Wall1.transform.position = Poshelp;

		Poshelp = Wall2.transform.position;
		Poshelp.x += speed * Time.deltaTime;


		Wall2.transform.position = Poshelp;

		Poshelp = Wall3.transform.position;
		Poshelp.x += speed * Time.deltaTime;

		Wall3.transform.position = Poshelp;

		Poshelp = Trigger.transform.position;
		Poshelp.x += speed * Time.deltaTime;

		Trigger.transform.position = Poshelp;
	}
}
