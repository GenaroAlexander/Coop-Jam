using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

    public int currentMinion;

    public CamScript theCam;

    public bool sideView;

	// Use this for initialization
	void Start () {
        currentMinion = 1;
        //currCamOrient = 1;
        sideView = true;
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

        if(Input.GetKeyDown(KeyCode.Q))
        {
            sideView = !sideView;
            theCam.SwitchPersp();
        }

	}
}
