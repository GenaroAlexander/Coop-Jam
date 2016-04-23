using UnityEngine;
using System.Collections;

public class CamScript : MonoBehaviour 
{

    public GameObject thinPlayer;
    public GameObject thickPlayer;
    public GameData gamestats;
    public Vector3 offset;

	// Use this for initialization
	void Start () 
    {
	
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
}
