using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cannon script. This script is planned to handle the following;
/// * Upon player colliding with self, turn off mesh render for player (entering cannon)
/// * Keep player static when inside cannon
/// * on input of button fire cannon. However firing cannon can only happen
/// when inside a cannon (exiting cannon.)
/// 
/// * Keep the game from thinking that we're in every cannon that is able to fire
/// Basically, have each cannon "active" when player is inside cannon, 
/// but "inactive" when player is outside cannon.
/// 
/// Update: turns out a set active on player works just as good as making a cannon active. In fact all the cannons are always active.
/// Just probably need a differnt script for the moving cannons
///
/// </summary>




public class CannonController : MonoBehaviour
{
    public PlayerScript playerScript;
    public static Transform currentCannon;

    public void FireStaticCannon()
    {
        if (playerScript.inStaticCannon == true) // if the player is in a static cannon
        {
            playerScript.gameObject.transform.localRotation = Quaternion.identity; // make rotation 0,0 so it can set it self up to take in the parent's transform
            if (Input.GetKeyDown(KeyCode.C)) // if the C key is pressed
            {
                playerScript.gameObject.transform.localPosition = new Vector2(2f, 0); // set it's transform to 0,0 relative to it's parent.
                
                playerScript.gameObject.SetActive(true); // activate the player

                Debug.Log("FIRE!"); // print a log that says the string.
                
                playerScript.gameObject.transform.SetParent(null); // set the player's parent to world
                
                playerScript.playerRB.velocity = Vector2.zero; // "freezes" all velocity that the player may of had upon entering a cannon.
                playerScript.playerRB.AddForce(currentCannon.right * playerScript.launchPower); //tells the rigid body to addforce in the pos X direction (or 'right' in this case)
                playerScript.inStaticCannon = false; // tells the bool variable to be false so that the player is no longer inside a cannon
                
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        FireStaticCannon(); // performs the function
    }








}
