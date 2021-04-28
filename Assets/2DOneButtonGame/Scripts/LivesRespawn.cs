using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesRespawn : MonoBehaviour
{
    // handles lives, deaths and respawns
    // will call the "isDed" function from PlayerScript
    public PlayerScript playerscript;
   
    public GameObject master;


    public int lives = 3;


    public bool isDed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDed && lives > 0)
        {
            StartCoroutine(Respawning());
        }
    }

    IEnumerator Respawning()
    {
        //float length = 1;
        Debug.Log("You, YES YOU! You are dead!");

        isDed = false;

        yield return new WaitForSeconds(5);
        //playerscript.gameObject.transform.SetParent(transform.parent, false);

        playerscript.gameObject.transform.SetParent(null);
        playerscript.gameObject.SetActive(true);

        if (lives > 0)
        {
            Debug.Log("I am still alive!");
        }


    }
}
