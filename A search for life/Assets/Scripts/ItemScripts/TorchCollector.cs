using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchCollector : MonoBehaviour

{
    public GameObject theTorch;
    public GameObject playerCave;
    public GameObject thePot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerCave" && ItemController.torchInPot == false) 
        {
            theTorch.transform.parent = playerCave.transform;
            Debug.Log("Grabbed Torch");
            ItemController.torchCollected = true;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.gameObject == thePot)
        {
            Debug.Log("Dropped off the Torch");
            theTorch.transform.SetParent(null);
            ItemController.torchInPot = true;
            ItemController.torchCollected = false;

        }
    }
}
