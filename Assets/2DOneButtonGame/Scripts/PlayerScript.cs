using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The script that controls the player. The purpose of this script is planned to have;
/// 
/// (While player isn't able to move on their own, they are able to control when they fire out of the cannon)
/// * a check to whether player is inside cannon
/// * A check to see if touching the victory "platform" (platform is a place holder)
/// * A check to see if the player is touching the death barrier 
/// * If the player is touching this death barrier, the player is destroyed
/// * When player is destroyed, lose a life.
/// *
/// 
/// </summary>
public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float launchPower = 5000.0f;


    public GameObject player;


    public bool inStaticCannon;
    public bool inMovingCannon;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>(); // the current player's rigid body
        //player = gameObject;
    }





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.SetActive(true);
            if (inStaticCannon == true)
            {



                

                Debug.Log("FIRE!");
                playerRB.velocity = Vector2.zero;
                playerRB.AddForce(transform.right * launchPower);
            }
            
        }
    }
  
    private void FixedUpdate()
    {
        
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("staticCannon")) // if a collision with a collider on  agame object that has a tag named "staticCannon" happens
        {
            gameObject.SetActive(false); // set the current gameObject's "set active" to false. Which means basically making it inactive
            inStaticCannon = true;
            Debug.Log("Fire when ready!");
           
        }
    }

}
