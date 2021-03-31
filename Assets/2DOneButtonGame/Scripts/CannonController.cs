using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cannon script. This script is planned to handle the following;
/// * Upon player colliding with self, turn off mesh render for player (entering cannon)
/// * Keep player static when inside cannon
/// * on input of button fire cannon. However firing cannon can only happen
/// when inside a cannon (exiting cannon.)
/// 
/// * Keep the game from thinking that we're in every cannon that is able to fire
/// Basically, have each cannon "active" when player is inside cannon, 
/// but "inactive" when player is outside cannon.
/// 
/// 
///
/// </summary>




public class CannonController : MonoBehaviour
{
    public GameObject Cannon;
    public bool inCannon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CannonEnter()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

    }







}
