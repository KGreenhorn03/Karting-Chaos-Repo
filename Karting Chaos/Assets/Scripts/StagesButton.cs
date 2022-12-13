using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Uses UnityEngine.SceneManagement.

public class StagesButton : MonoBehaviour
{

    // Declare variable.

    public string stage;

    public void Stage()
    {

        // Make the chosen scene load when the function is called.

        SceneManager.LoadScene(stage);

    }

    public void Quit()
    {

        // Quits the program.

        Application.Quit();

    }
}
