using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {
    public movement move;

    void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            move.enabled = false;
        }
    }
        
   }


