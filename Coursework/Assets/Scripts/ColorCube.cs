using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCube : MonoBehaviour
{

    public void colorCube()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            GetComponent<Renderer>().material.color = new Color(255, 0, 26); // красный цвет
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            GetComponent<Renderer>().material.color = new Color(0, 50, 255); // синий цвет
        }
        else if (Input.GetKey(KeyCode.Keypad3))
        {
            GetComponent<Renderer>().material.color = new Color(255, 128, 0); // оранжевый цвет
        }
    }
}