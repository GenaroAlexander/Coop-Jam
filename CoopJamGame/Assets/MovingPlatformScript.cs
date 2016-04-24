using UnityEngine;
using System.Collections;

public class MovingPlatformScript : MonoBehaviour 
{

    public Vector3 moveDir;
    public float speed;
    public float timeDir;

    float timeHelp;


	// Use this for initialization
	void Start () {
        timeHelp = 0;
	}
	
	// Update is called once per frame
	void Update () {

        timeHelp += Time.deltaTime;

        transform.position += moveDir * speed * Time.deltaTime;

        if(timeHelp >= timeDir)
        {
            timeHelp = 0;
            moveDir *= -1;
        }

	}
}
