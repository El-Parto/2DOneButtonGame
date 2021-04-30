using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField]
    private PlayerScript playerScript4;

    [SerializeField]
    private LivesRespawn livRes;

    public new Camera camera;
    public Transform startCamPos;
    public Vector3 waypoint;

    // Start is called before the first frame update
    void Start()
    {
        startCamPos = camera.transform; 
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




