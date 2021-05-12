using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void GameStart()
    {
        //_sceneName = "Version006";
        SceneManager.LoadScene("Version006");
        Debug.Log("It should load");
    }
    public void ExitGame()
    {



#if     UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit;
#endif
    }

}

