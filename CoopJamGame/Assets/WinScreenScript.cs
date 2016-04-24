using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinScreenScript : MonoBehaviour 
{

	public void MyFunc(string name)
    {
        SceneManager.LoadScene(name);
    }

}
