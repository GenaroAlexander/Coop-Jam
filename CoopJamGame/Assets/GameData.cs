using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

    public int currentMinion;

	// Use this for initialization
	void Start () {
        currentMinion = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (currentMinion == 1)
                currentMinion = 2;
            else
                currentMinion = 1;
        }

	}
}
