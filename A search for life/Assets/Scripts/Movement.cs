using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//The player of the cave will be reversed
public class Movement : MonoBehaviour
{

    //To hit platforms
    [SerializeField] private LayerMask lm;


    //Speeds
    public float speedIce = 4.0f;
    public float speedCave = -4.0f;
    private float jumpVel = 7.0f;



    public GameObject icePlayer;
    public GameObject cavePlayer;


    public Rigidbody2D iceRb;
    public Rigidbody2D caveRb;


    public BoxCollider2D boxColIce;
    public BoxCollider2D boxColCave;


    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 positionIce = icePlayer.transform.position;
        Vector2 positionCave = cavePlayer.transform.position;

        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
 
            positionIce.x -= 0.05f * speedIce;
            icePlayer.transform.position = positionIce;

            positionCave.x -= 0.05f * speedCave;
            cavePlayer.transform.position = positionCave;

        }
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            
            positionIce.x += 0.05f * speedIce;
            icePlayer.transform.position = positionIce;


            positionCave.x += 0.05f * speedCave;
            cavePlayer.transform.position = positionCave;
        }


        //Jumping

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (IsGroundedIce())
            {
                iceRb.velocity = Vector2.up * jumpVel;

            }
            if(IsGroundedCave())
            { 
                caveRb.velocity = Vector2.up * jumpVel;
            }
        }


        //if stuck
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
    }

    //isJumping?
    private bool IsGroundedIce() 
    {
        RaycastHit2D theRayIce = Physics2D.BoxCast(boxColIce.bounds.center, boxColIce.bounds.size, 0.0f, Vector2.down, 0.1f, lm);

        Debug.Log(theRayIce);
        return theRayIce.collider != null;
    }

    private bool IsGroundedCave()
    {
        RaycastHit2D theRayCave = Physics2D.BoxCast(boxColCave.bounds.center, boxColCave.bounds.size, 0.0f, Vector2.down, 0.1f, lm);

        Debug.Log(theRayCave);
        return theRayCave.collider != null;
    }



}
