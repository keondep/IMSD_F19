using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    //how long 
    public int amplitude = 1;
    //howfast
    public float frequency = 1.0f;
    public float cos2frequency = 1.0f;
    public int cos2amplitude = 1;
 

    void Update()


    {
        float z = Mathf.Cos(Time.time * cos2frequency) * cos2amplitude;
        float y = Mathf.Sin(Time.time * frequency) * amplitude;
        float x = Mathf.Cos(Time.time * frequency) * amplitude;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, y  , 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, z , 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3( x  , 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3( -x , 0, 0);
        }
    }
}
