using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interativescript : MonoBehaviour
{
    public GameObject cubes;
    public Light partylights;
    public GameObject cylinder;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey("s"))
        {
            cubes.transform.localScale = new Vector3(Random.Range(0.10f,5.0f), 2, Random.Range(0.15f, 5.0f));
        }
        if (Input.GetKey("p"))
        {
            partylights.color = new Color(Random.Range(0.10f, 5.0f), .5f, Random.Range(0.3f, 8.0f));

        }
        if (Input.GetKey("c"))
        {
            cylinder.transform.localScale = new Vector3(Random.Range(0.10f, 5.0f), 2, Random.Range(0.15f, 5.0f));
        }
    }
}
