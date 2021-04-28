using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesRespawn : MonoBehaviour
{
    // handles lives, deaths and respawns
    // will call the "isDed" function from PlayerScript
    public PlayerScript playerscript;

    public int lives = 3;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    }

    IEnumerator Respawning()
    {
        Debug.Log("You, YES YOU! You are dead!");

        yield return new WaitForSeconds(5);
        // playerscript.gameObject.transform
    }
}
