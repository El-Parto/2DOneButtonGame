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
    public PlayerScript playerscript;


    public void FireStaticCannon()
    {
        if (playerscript.inStaticCannon == true)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                playerscript.gameObject.SetActive(true);

                Debug.Log("FIRE!");
                playerscript.playerRB.velocity = Vector2.zero;
                playerscript.playerRB.AddForce(transform.right * playerscript.launchPower); //tells the rigid body to addforce in the pos X direction (or 'right' in this case)
                playerscript.inStaticCannon = false;
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        FireStaticCannon();
    }








}
