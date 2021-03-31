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
    private Rigidbody2D playerRB;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
