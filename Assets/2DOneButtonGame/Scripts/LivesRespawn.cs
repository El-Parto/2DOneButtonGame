using System.Collections;
using UnityEngine;


/// <summary>
/// Handles The player's lives and respawning behaviour. 
/// (Does not include respawn point. Just handles respawning itself.)
/// </summary>
public class LivesRespawn : MonoBehaviour
{
    /*PS. I left all the old stuff I previously had in comments. Every bit of info helps I suppose*/
    

    // handles lives, deaths and respawns
    // will call the "isDed" function from PlayerScript
    public PlayerScript playerscript;


    //public CameraMover camMove;
    /* ^ The above was supposed to reference the camera mover script class,
    but after seeing that constraints behave pretty much the same as they do in Maya. 
    I figured it was easier to do it that way instead of this. I do have that sense of dread that doing it 
    this way may be going in that "learning the wrong way" path but...I'm still optimistic!*/


    //public GameObject master; // Trying to figure out where i should put the parent of the camera to move it.

    public int lives = 6; // the amount of lives the player is meant to have. I made it 3 in the editor just to see if it was working properly.

    public bool isDed = false; // A boolean variable to check whether or not the player is "Ded". PS. It is Canon that the Cannonball survives.


    void Update()
    {
        if (isDed && lives > 0) // if you are dead and have at least more than 0 lives.
        {
            StartCoroutine(Respawning()); // start the Respawning Coroutine
        }
    }



    /// <summary>
    ///  This Coroutine handles what happens when the player has died.
    /// </summary>
    IEnumerator Respawning()
    {
        
        Debug.Log("You, YES YOU! You are dead!"); // Debugging to see if the coroutine itself starts

        isDed = false; // "Okay let's get you back out there" The player is " revived ".

        yield return new WaitForSeconds(3); // But wait! Respawn timers exist! You must wait 3 seconds before passing "Go"
        //playerscript.gameObject.transform.SetParent(transform.parent, false);// This was to ensure the player goes back to the right spot, but that's handled in a different script.

        playerscript.gameObject.transform.SetParent(null); // Frees the player from their hierarchy and lets them wonder the world anew
        playerscript.gameObject.SetActive(true); // Re-activates the player. Kinda silly when you think about it that way.
        
        if (lives > 0) // If you have greater than 0 lives.
        {
            Debug.Log("Back from the dead!"); // Debugging a message just for peace of mind. "THIS TIME hopefully it will work"
            //camMove.camera.transform.position = Vector3.zero; // This was also a way I thought of to reset the camera back to the "start position"
        }

        /// <summary>
        ///  When you die, you are given time to evaluate your deciscion making,
        ///  then you tend to wonder, why is there a break time in a fast paced barrel shooter game?
        ///  Well it's because i didn't make the camera movement a "transition" rather, a "cut"
        /// </summary>
    }
}
