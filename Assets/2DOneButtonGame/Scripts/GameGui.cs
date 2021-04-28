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



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(livesRespawn1.lives == 0)
        {
            Debug.Log("GAMEOVER");
        }

    }
}
