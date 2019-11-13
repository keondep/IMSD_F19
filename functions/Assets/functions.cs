using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    Transform sphere;
    Transform cube;
    void Start()
    {
        sphere = transform.GetChild(0);
        cube = transform.GetChild(1);
    }

    
    void Update()
    {
        changeScale(sphere);
        changeRotation(cube);
    }
    void changeScale(Transform scale)
    {
        if (Input.GetKey("s"))
        {
            scale.transform.localScale = new Vector3(Random.Range(0.10f, 5.0f), 2, Random.Range(0.15f, 5.0f));
        }
    }
    void changeRotation(Transform rotate)
    {
        if (Input.GetKey("r"))
        {
            rotate.transform.Rotate(4, 5, 6, Space.Self);
        }
    }


}