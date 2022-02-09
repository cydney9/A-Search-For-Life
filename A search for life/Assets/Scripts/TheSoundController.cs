using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSoundController : MonoBehaviour
{
 
    private bool musicOn;
    // Start is called before the first frame update
    void Start()
    {
        musicOn = true; 
    }

    // Update is called once per frame
    void Update()
    {

        soundToggle();
        if (musicOn == true)
        {
            AudioListener.volume = 1.0f;
        }
        else 
        {
            AudioListener.volume = 0.0f;

        }
       
    }

    void soundToggle() 
    {
        if (Input.GetKeyDown(KeyCode.M) && musicOn == true)
        {
            musicOn = false;
        }
        else if (Input.GetKeyDown(KeyCode.M) && musicOn == false)
        {
            musicOn = true;
        }
    }
}
