using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    // Toggle mute function to work as a button to ensure the player controls audio.
    public void ToggleMute(bool muted)
    {
        // If the button is pressed audio is muted.

        if (muted)
        {

            AudioListener.volume = 0;

        }

        // Unless button is pressed audio remains active.

        else
        {

            AudioListener.volume = 1;

        }

    }

}