using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class colorchange : MonoBehaviour
{
    private float setTime;
    private float someAmountOfTime;
    public Color startColor;
    public Color mouseOverColor;
    bool mouseOver = false;
    public GameObject pic;

    private void Start()
    {
        setTime = 0;
        someAmountOfTime = 5;
    }
    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
        //  if (setTime < someAmountOfTime)
        // {
        //   pic.SetActive(true);
        // }
        pic.SetActive(true);

    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
       // if (setTime > someAmountOfTime)
       // {
        //  pic.SetActive(false);
        // setTime = 0;
       // }
        pic.SetActive(false);
    }
}