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
    public Transform waypoint;

    // Start is called before the first frame update
    void Start()
    {
        startCamPos = camera.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
