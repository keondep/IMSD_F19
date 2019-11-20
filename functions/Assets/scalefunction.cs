using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalefunction : MonoBehaviour
{
    public float increasescale = 1f;
    public float decreasescale = 6f;
    Transform[] box = new Transform[3];
    public GameObject prefabcube;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
 GameObject g = Instantiate(prefabcube, new Vector3(-8 + 2 * i, 0, 0), Quaternion.identity);
        box[i] = g.transform;
        }
           
    }

    // Update is called once per frame
    void Update()
    {
        scaleup(box[0], Input.GetKey(KeyCode.U));
    }
    void scaleup(Transform cubes, bool scaledown)
    {
        if (scaledown)
            cubes.localScale = new Vector3(Time.deltaTime * increasescale, Time.deltaTime * increasescale, Time.deltaTime * increasescale);
        else
            cubes.localScale = new Vector3(Time.deltaTime - increasescale, Time.deltaTime - increasescale, Time.deltaTime - increasescale);
    }
}
