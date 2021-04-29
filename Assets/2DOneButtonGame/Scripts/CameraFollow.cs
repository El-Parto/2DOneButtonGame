using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   // public PlayerScript playerScript1;

    [SerializeField] private Transform target = null;
    [SerializeField] private Vector3 offset = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        // If it is not set, ignore the update frame
        if(target == null)
            return;

        transform.position = target.position + offset;
    }






}
