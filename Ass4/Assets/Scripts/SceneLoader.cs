using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string Pacman)
    {
        SceneManager.LoadScene(Pacman);
    }

    public void RedesignScene(string DesignIteration)
    {
        SceneManager.LoadScene(DesignIteration);
    }
}
