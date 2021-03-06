using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// pretty much this entire class is thanks to James. 
/// I mean he does a good job at teaching classes.
/// </summary>
public class CannonMoving : MonoBehaviour
{
    [SerializeField] private float moveSpeed; // a float that will set the movespeed of the current object (a cannon.)
    //[SerializeField] private float timer = 5f;


    [SerializeField] private Vector3 currentPos; // this will take in the current position of an object using a vector3
    [SerializeField] private Transform endpos; // This will set the endposition via a transform class (the transform rect)

    private Vector3 start; // a vector3 variable to set the start position
    private Vector3 end; // a vector3 variable to set the end position

    void Start()
    {
        currentPos = gameObject.transform.position; //initialises the current position of the cannon
        start = currentPos; // the start variable now is equal to the currentPos variable.
        end = endpos.position; // and the  end is now equal to the endpos position
    }


    // Update is called once per frame
    void Update()
    {
        //Move(end);
        //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        //                                       number to reach before "pingponging" back
        float factor = Mathf.PingPong(Time.time, 1.5f); // a new variable float is equal to a mathf class that calls upon the pingpong function, for the object to move back and forth from (thanks (teacher)James!)
//  data type  variable                any value  
        // ping pong makes it so that it will keep moving back and forth between the time frame  and the length
        transform.position = Vector3.Lerp(start, end, factor); // moving the object using linear interpolation between the variable start and end by a factor of mathF pingpong. (again. Thanks James!)
    }

    //public void Move(Vector2 target)
    //{
    //    float step = moveSpeed * Time.deltaTime;

    //    // move sprite towards the target location
    //    transform.position = Vector2.MoveTowards(transform.position, target, step);
    //}

}
