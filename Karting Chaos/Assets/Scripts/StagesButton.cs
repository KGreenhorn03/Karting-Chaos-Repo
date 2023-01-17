using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Uses UnityEngine.SceneManagement.

public class StagesButton : MonoBehaviour
{

    // Declare variable.

    public string stage;

    public bool autoSelect;

    private void Start()
    {

        if (autoSelect)
        {

            GetComponent<Button>().Select();

        }

    }

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
