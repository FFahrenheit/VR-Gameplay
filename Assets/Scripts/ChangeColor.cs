using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void ChangeToRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void ChangeToBlue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void ChangeToBlack()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}
