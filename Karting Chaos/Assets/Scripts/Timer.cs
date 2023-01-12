using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    // Declare variables.

    private float startTime;
    private float elapsedTime;
    private bool hasStartedLap = false;

    public GameObject lapText;
    public GameObject prevLapText;
    public GameObject bestLap;
    public GameObject LapCounter;

    public int lapsDone;

    public int loadScene;

    List<float> bestTimes = new List<float>();

    private void Start()
    {

        loadScene = SceneManager.GetActiveScene().buildIndex + 1;

    }

    // Update is called once per frame.
    void Update()
    {
        
        if(hasStartedLap)
        {

            elapsedTime = Time.time - startTime;
            //Debug.Log(elapsedTime);
            lapText.GetComponent<Text>().text = "Lap Time: " + elapsedTime.ToString();
        
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if(GameObject.FindWithTag("Player"))
        {

            lapsDone += 1;

            hasStartedLap = true;
            startTime = Time.time;

            prevLapText.GetComponent<Text>().text = "Last lap: " + elapsedTime.ToString();

            LapCounter.GetComponent<Text>().text = "Lap: " + lapsDone;

        }

        prevLapText.GetComponent<Text>().text = "Last Lap: " + elapsedTime.ToString();

        if(elapsedTime != 0)
        {

            bestTimes.Add(elapsedTime);

        }

        if(bestTimes.Count > 0)
        {

            bestTimes.Sort();
            bestLap.GetComponent<Text>().text = "Best Lap: " + bestTimes[0].ToString();

        }

        if(lapsDone == 5)
        {

            SceneManager.LoadScene(loadScene);

        }

    }
}
