using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;
    public float jumpforce = 7;
    public LayerMask groundlayers;
    public SphereCollider col;

    void FixedUpdate()
{

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardforce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce , ForceMode.Impulse);
        }
if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().Endgame();
        }

    }
    private bool IsGrounded()
    {
      return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x , col.bounds.min.y, col.bounds.center.z),col.radius* .9f, groundlayers);
    
    }
}

