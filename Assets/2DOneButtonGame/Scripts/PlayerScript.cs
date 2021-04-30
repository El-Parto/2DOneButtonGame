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
    
    public LivesRespawn livesRespawn;
    public CameraMover camMoo;

    [SerializeField]
    private GameObject firepoint;
    public Rigidbody2D playerRB;
    public float launchPower = 2500.0f;
    //public GameObject player;
    public Transform parent;
 
    public bool inStaticCannon;
    public bool inMovingCannon;
    public bool winGame = false;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>(); // the current player's rigid body
        //player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (inStaticCannon == false) 
        {
            gameObject.transform.localScale = new Vector2(1, 1); // this is to set the scale of the cannon ball back to normal 1,1 scale
        }
        
        else
        {
            gameObject.transform.localPosition = new Vector2(0, 0);
        }
        */
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("staticCannon")) // if a collision with a collider on  agame object that has a tag named "staticCannon" happens
        {
            CannonController.currentCannon = collision.transform;
            gameObject.SetActive(false); // set the current gameObject's "set active" to false. Which means basically making it inactive

            inStaticCannon = true;
            Debug.Log("Fire when ready!");
            gameObject.transform.SetParent(collision.transform, false);


        }

        if (collision.collider.gameObject.CompareTag("dieOnContact")) // if a collision with a collider on  agame object that has a tag named "dieOnContact" happens
        {
            livesRespawn.lives -= 1;
            livesRespawn.isDed = true;

            //gameObject.transform.SetParent(parent.transform, false);
            gameObject.transform.SetParent(parent, false);
            gameObject.transform.localPosition = new Vector2(0, 0);
            gameObject.SetActive(false);
            
           

            //Debug.Log("You are ded. Not Big Souprice");

        }

        if (collision.collider.gameObject.CompareTag("You Win"))
        {
            winGame = true;
        }

    }


}




