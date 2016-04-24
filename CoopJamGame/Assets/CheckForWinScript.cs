using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class CheckForWinScript : MonoBehaviour {


    public WinPlatformScript redTrig, blueTrig;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(redTrig.Triggered && blueTrig.Triggered)
        {
            SceneManager.LoadScene("win screen");
        }

	}
}
