using UnityEngine;
using System.Collections;

public class CamScript : MonoBehaviour 
{

    public GameObject thinPlayer;
    public GameObject thickPlayer;
    public GameData gamestats;
    public Vector3 offset;

    bool sideView;

	// Use this for initialization
	void Start () 
    {
       // transform.Rotate(new Vector3(0, 1, 0), 90);
        sideView = true;
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
	     if(gamestats.currentMinion == 1)
         {
             transform.position = thinPlayer.transform.position + offset;
         }
         else
         {
             transform.position = thickPlayer.transform.position + offset;
         }
	}

   public  void SwitchPersp()
    {
        sideView = !sideView;

        if(sideView)
        {
            offset = new Vector3(0, 2, -15);
            transform.Rotate(new Vector3(0, 1, 0), -90);
        }
        else
        {
            transform.Rotate(new Vector3(0, 1, 0), 90);
            offset = new Vector3(-15, 2, 0);
        }
    }
}
