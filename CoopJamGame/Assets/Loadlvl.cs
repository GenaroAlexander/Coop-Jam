using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loadlvl : MonoBehaviour {

    public void Loadlevel(string name)
    {


        SceneManager.LoadScene(name);
    }
    public void Quit()
    {
        Application.Quit();
    }

    
    void Update()
    {
    }
}

