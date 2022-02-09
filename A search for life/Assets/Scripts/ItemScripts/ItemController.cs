using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ItemController : MonoBehaviour
{
    //Item Bools

    //In Hand
    public static bool torchCollected = false;
    public static bool iceCollected = false;
    
    //Dropped off
    public static bool iceInPot;
    public static bool torchInPot;

    //Ending timer

    private float theTimer;

    // Start is called before the first frame update
    void Start()
    {
        theTimer =1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (iceInPot == true && torchInPot == true) 
        {
            theTimer -= Time.deltaTime;
            Debug.Log(theTimer);
            if (theTimer <= 0) {
               
                SceneManager.LoadScene("Ending");
            }
        }
        
        
    }
}
