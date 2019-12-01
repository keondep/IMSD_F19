using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class colorchange : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    bool mouseOver = false;
    public GameObject pic;
    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
        pic.SetActive(true);
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
        pic.SetActive(false);
    }
}