using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCollector : MonoBehaviour 
{ 

    public GameObject theIce;
    public GameObject playerIce;
    public GameObject thePot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerIce" && ItemController.iceInPot == false)
        {
            theIce.transform.parent = playerIce.transform;
            Debug.Log("Grabbed the Ice");
            ItemController.iceCollected = true;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.gameObject == thePot) 
        {
            Debug.Log("Dropped off the Ice");
            theIce.transform.SetParent(null);
            ItemController.iceInPot = true;
            ItemController.iceCollected = false;

        }
    }
}
