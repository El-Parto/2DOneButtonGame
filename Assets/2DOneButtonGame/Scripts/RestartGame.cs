using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField]
    private LivesRespawn livRes;
    [SerializeField]
    private PlayerScript playScrip;

    // Update is called once per frame
    void Update()
    {
        if (livRes.lives == 0)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                SceneManager.LoadScene("Version005");
            }
        }
        if (playScrip.winGame == true)
        {

        }

    }
}
