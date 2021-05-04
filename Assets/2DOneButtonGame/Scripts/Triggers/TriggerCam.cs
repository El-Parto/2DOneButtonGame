using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


/// originally meant to handle when the camera passes  trigger points, 
/// but I goofed and went with Constraints because I understood them better.
/// My main trouble was trying to set the position of a game objects child (the trigger and it's waypoint child)
/// .... why i couldn't remember "getComponentInChildren<Transform>()" ... Uhh.. Yeah. ...call it adlib.
/// Its off the script yeah?
public class TriggerCam : MonoBehaviour
{
    // this will affect the player as they come into the collider/trigger

    public PlayerScript playerScript5; // declaring the player script. Boy the player sure gets around huh?
   

    public Camera mainCamera; // the main camera stored as a variable. please don't kill me for not having "new"
   
    

    // Update is called once per frame
    void Update()
    {
        // runs this every waking nano second of its life.
        PosConstraintOnOff();
    }

    /// <summary>
    /// Handles the behaviour of the Position constraint attached to the main camera. 
    /// I believe a better way would be using "RequireComponent" if i knew beforehand that this -
    /// was meant to be for the camera and only the camera.
    /// </summary>
    public void PosConstraintOnOff()
    {
        // Disables or enables  the position constrained whether or not if the player is in a cannon.
        if (playerScript5.inStaticCannon == true) // if  the player is in a cannon (I was afraid to change the variable name incase i forgot to change one character again)
        {
            mainCamera.GetComponent<PositionConstraint>().enabled = false; // disable the position constraint
        }
        else
            mainCamera.GetComponent<PositionConstraint>().enabled = true; // enables it
        //this is to prevent the sawaying motion of the cannonent as it is rotating.
        // because the Game  object for some reason isn't at the parent's position....That's a bug....and a me problem.
        
    }
    
    
    //  this was where i was going to handle triggers. I think ran into a problem where the error was Vector3 aren't transforms.
    // and i didn't realise that i probably just needed a vector 3 variable to say camPos.z = blahblah.
  /*  private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Player"))
        {
            mainCamera.transform.position = trigger.gameObject.GetComponentInChildren<Transform>();
        }
    }
  */

}
