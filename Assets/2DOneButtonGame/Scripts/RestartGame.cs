using UnityEngine;
using UnityEngine.SceneManagement; // the name space used for Scene related behaviours.

public class RestartGame : MonoBehaviour
{
    [SerializeField]
    private LivesRespawn livRes; // referencing the LivesRespawn Class with a variable.
    [SerializeField]
    private PlayerScript playScrip; // Referencing the PlayerScript class with a variable.

    void Update()
    {

        //Reloading the game if the player got a game over.
        if (livRes.lives == 0) // if the LivesRespawn variable "lives" is equal to 0 then run
        {
            if (Input.GetKeyDown(KeyCode.C)) // If the C key is pressed
            {
                SceneManager.LoadScene("Version006"); // This will load the scene given as a string.
            }
        }
        //Exiting the game upon victory.
        ExitGame(); // runs the function

    }
    /// <summary>
    /// Handles exiting the game whether it be from Unity Editor or the exe file.
    /// </summary>
    private void ExitGame()
    {
        if (playScrip.winGame == true)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #else
                    Application.Quit;
                #endif
            }
        }
    }
}
