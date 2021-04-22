using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonSpinner : MonoBehaviour
{
    [SerializeField] float speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        /*
        //movement psudocode
        Transform cannon,pointA,pointB;
        float timer = 0;

        cannon.transform.position = Vector3.Lerp(pointA,pointB,timer);
        */
    }
    
}
