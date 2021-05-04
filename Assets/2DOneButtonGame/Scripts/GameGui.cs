using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//The tedious world of GUI programming.

/// <summary>
///  Handles everything for the GUI behaviour.
/// </summary>
public class GameGui : MonoBehaviour
{
    public PlayerScript playerscript3; // A refernce for the class
    public LivesRespawn livesRespawn1; // Another class declaration. Variables are too gullible.

    [SerializeField]
    private TMP_Text livesText; // a serialized and privatised TMP Text variable. Kinda ironic that it isn't making money.
    [SerializeField]
    private TMP_Text gameOverText; // Serialised with private access. Like a Lovey Dovey hotel specifically requesting Game Overs only. Can you imagine?
    [SerializeField]
    private Button restartButton; // Serialized private button. Look, after the above comment do you really want me to push your buttons here?

    [SerializeField]
    private TMP_Text winningText;// A winning Serialised text variable that's just for the player that wins <3... Yeah, I promise I wont do that again.

    public new Camera camera; // A new camera declaration signing that they are infact a different camera.
    private Vector3 camPos;// Meant for getting access to the camera's position as a vector 3 variable.

    private void Update()
    {
        NumberOLives();
        ShowGameOverRestart();
        ShowWinScreen();
    }

    /// <summary>
    /// How many lives you currently have displayed as TMP text
    /// </summary>
    public void NumberOLives()
    {
        livesText.text = $"Lives: {livesRespawn1.lives}"; //Thanks(taecher)James for the reminder. the text now equals the formatted string
        // a $ with a string is used for formatting.
    }

    /// <summary>
    /// Handles behaviour for when if your lives = 0 or when you win the game.
    /// </summary>
    public void ShowGameOverRestart()
    {
       // Getting Game Overs.
        if (livesRespawn1.lives == 0)
        {
            camPos.z = 0; // Setting the Z axis of camPos to 0
            camera.transform.position = camPos;// making the camera's position to camPos. ------ It's good for prototypes to show a different "screen" but if i had more time, i would of inserted an image here.
            gameOverText.gameObject.SetActive(true); // Activates the game over text variable's game object.
            Debug.Log("GAMEOVER"); // debugs and logs out the string variable.  ------- I'd reference Police Academy but that particular line isn't TAFE friendly.
            // when you realise that every game dev has to make their character suffer because it's a condition.
        }

    }
    /// <summary>
    /// Handles the behaviour for when the player "Wins" the game.
    /// PS. It is Canon. For the Cannon to exist with a Cannonball in this game.
    /// I guess you could say the game is called.. "Canonball"...Its officially Canon.
    /// </summary>
    public void ShowWinScreen()
    {
        if (playerscript3.winGame == true)// If playerScript detects that the winGame is currently true.
        {
            livesText.gameObject.SetActive(false);// deactivate lives because you won! ...Wow don't think too deeply into that one.
            camPos.z = 0; // like with the game over script, only again being used here too.
            camera.transform.position = camPos; // The reason I do it this way...well, it was easier.

            winningText.gameObject.SetActive(true);// Activates the winningText variable to let the player know they did good.
            Debug.Log("You win!");// Logs out the string provided. You won son. You won.
        }
    }
}
