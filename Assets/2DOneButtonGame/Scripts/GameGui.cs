using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameGui : MonoBehaviour
{
    public PlayerScript playerscript3;
    public LivesRespawn livesRespawn1;

    [SerializeField]
    private TMP_Text livesText;
    [SerializeField]
    private TMP_Text gameOverText;
    [SerializeField]
    private Button restartButton;
    

    public void NumberOLives()
    {
        livesText.text = livesText + livesRespawn1.lives.ToString();
    }

    public void ShowGameOverRestart()
    {
       
        if (livesRespawn1.lives == 0)
        {
            gameOverText.gameObject.SetActive(true);
            Debug.Log("GAMEOVER");
            restartButton.gameObject.SetActive(true);

        }

    }


}
