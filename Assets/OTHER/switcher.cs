using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switcher : MonoBehaviour
{
    [Header("Scene Names")]
    public string MAIN;
    public string NewMain;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Check the current scene
            string current = SceneManager.GetActiveScene().name;

            // If we are in sceneA, switch to sceneB
            if (current == MAIN)
            {
                SceneFader.Instance.FadeToScene(NewMain);
            }
            // If we are in sceneB, switch to sceneA
            else if (current == NewMain)
            {
                SceneFader.Instance.FadeToScene(MAIN);
            }
        }
    }
}


