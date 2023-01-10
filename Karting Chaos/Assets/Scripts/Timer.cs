using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    private float startTime;
    private float elapsedTime;
    private bool hasStartedLap = false;

    public GameObject lapText;
    public GameObject prevLapText;
    public GameObject bestLap;
    public GameObject LapCounter;

    public int lapsDone;

    List<float> bestTimes = new List<float>();

    // Update is called once per frame
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

    }
}
