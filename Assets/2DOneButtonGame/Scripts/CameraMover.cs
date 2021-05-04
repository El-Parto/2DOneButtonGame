using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Because of constraints this script is entirely not necessary.
/// </summary>
public class CameraMover : MonoBehaviour
{
    [SerializeField]
    private PlayerScript playerScript4;// referencing the playerscript.
    /* By the way, i numbered them based of a youtube tutorial saying that numbering them
     But then i realised I never numbered livRes, but it still worked.
    Is it good practice to number variables with the same names if they reference the same thing across different scripts?*/
    [SerializeField]
    private LivesRespawn livRes;

    public new Camera camera; // Declaring a new camera class so Unity doesn't get confused about what camera are we using.
    public Transform startCamPos; // The transform class being used as a variable to store the intial camera position
    public Vector3 waypoint;

    // Start is called before the first frame update
    void Start()
    {
        //startCamPos = camera.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Player"))
        {
            // need a way to either A move cam to differnt waypoints based on trigger
            // or B a single Waypoint that moves to each position based on trigger
            // might try A
            /* Need a waypoint, how do we reference the waypoint?
             * 
      
            waypoint = trigger.transform.GetComponentInChildren<Transform>(); // what thisshould do, the waypoint is equal to the transform of what you set the trigger for
            // then updates the camera's position to the position of the waypoint.
            camera.transform.position = waypoint.position;
            //camFollow.transform.position = collision.gameObject.;
        }
    */
}




