using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TriggerCam : MonoBehaviour
{
    // this will affect the player as they come into the collider/trigger


    public PlayerScript playerScript5;
   

    public Camera mainCamera;
    //public PositionConstraint posCon;
    

    // Update is called once per frame
    void Update()
    {
        PosConstraintOnOff();
    }


    public void PosConstraintOnOff()
    {
        if (playerScript5.inStaticCannon == true)
        {
            mainCamera.GetComponent<PositionConstraint>().enabled = false;
        }
        else
            mainCamera.GetComponent<PositionConstraint>().enabled = true;
    }

  /*  private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Player"))
        {
            mainCamera.transform.position = trigger.gameObject.GetComponentInChildren<Transform>();
        }
    }
  */

}
