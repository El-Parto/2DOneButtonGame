using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesRespawn : MonoBehaviour
{
    // handles lives, deaths and respawns
    // will call the "isDed" function from PlayerScript
    public PlayerScript playerscript;

    public GameObject parent;


    public int lives = 3;
    
    
    public bool isDed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDed)
        {
            StartCoroutine(Respawning());
        }



    }

    IEnumerator Respawning()
    {
        if (lives > 0)
        {
            float length = 1;
            for (int i = 0; i < length; i++)
            {
                Debug.Log("You, YES YOU! You are dead!");
            }


            yield return new WaitForSeconds(5);
            playerscript.gameObject.transform.SetParent(transform.parent, false);
            isDed = false;
            playerscript.gameObject.transform.SetParent(null);
            playerscript.gameObject.SetActive(true);


            Debug.Log("I am still alive!");
        }
    }
}
