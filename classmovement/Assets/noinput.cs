using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noinput : MonoBehaviour
{
    //how long 
    public int amplitude = 1;
    //howfast
    public float frequency = 1.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == false)
        {
            //Grab original position
            Vector3 beep = transform.position;
            //Modify position
            beep.x = Mathf.Cos(Time.time) * 3;
            beep.y = Mathf.Sin(Time.time) * 3;
            beep.z = Mathf.Cos(Time.time) * 3;
            //Apply position
            transform.position = beep;
        }
   else
        {

            float x = Mathf.Cos(Time.time * frequency) * amplitude;
            float z = Mathf.Sin(Time.time * frequency) * amplitude;
            float y = Mathf.Tan(Time.time * frequency) * amplitude;
            transform.position = new Vector3(x, y, z);
        }

    }
}