//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //this function loads a scene of the scenename entered within unity
    public void LoadScene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}
