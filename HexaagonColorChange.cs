using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HexaagonColorChange : MonoBehaviour
{
    public MeshRenderer hexagon;
    public MeshRenderer hexagon2;
    public MeshRenderer hexagon3;
    public MeshRenderer hexagon4;
    public MeshRenderer hexagon5;
    public MeshRenderer hexagon6;
    public MeshRenderer hexagon7;
    public MeshRenderer hexagon8;
    public MeshRenderer hexagon9;
    public MeshRenderer hexagon10;
    public MeshRenderer hexagon11;
    public MeshRenderer hexagon12;
    public MeshRenderer hexagon13;
    public MeshRenderer hexagon14;
    public MeshRenderer hexagon15;
    public MeshRenderer hexagon16;
    public MeshRenderer hexagon17;
    public MeshRenderer hexagon18;
    public MeshRenderer hexagon19;
    public MeshRenderer hexagon20;
    public MeshRenderer hexagon21;
    public MeshRenderer hexagon22;

    public Slider red;
    public Slider green;
    public Slider blue;



    // Update is called once per frame
    public void OnEdit()
    {
        Color color = hexagon.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;

        hexagon.material.color = color;
        hexagon.material.SetColor("_EmissionColor", color);
        hexagon2.material.color = color;
        hexagon2.material.SetColor("_EmissionColor", color);
        hexagon3.material.color = color;
        hexagon3.material.SetColor("_EmissionColor", color);
        hexagon4.material.color = color;
        hexagon4.material.SetColor("_EmissionColor", color);
        hexagon5.material.color = color;
        hexagon5.material.SetColor("_EmissionColor", color);
        hexagon6.material.color = color;
        hexagon6.material.SetColor("_EmissionColor", color);
        hexagon7.material.color = color;
        hexagon7.material.SetColor("_EmissionColor", color);
        hexagon8.material.color = color;
        hexagon8.material.SetColor("_EmissionColor", color);
        hexagon9.material.color = color;
        hexagon9.material.SetColor("_EmissionColor", color);
        hexagon10.material.color = color;
        hexagon10.material.SetColor("_EmissionColor", color);
        hexagon11.material.color = color;
        hexagon11.material.SetColor("_EmissionColor", color);
        hexagon12.material.color = color;
        hexagon12.material.SetColor("_EmissionColor", color);
        hexagon13.material.color = color;
        hexagon13.material.SetColor("_EmissionColor", color);
        hexagon14.material.color = color;
        hexagon14.material.SetColor("_EmissionColor", color);
        hexagon15.material.color = color;
        hexagon15.material.SetColor("_EmissionColor", color);
        hexagon16.material.color = color;
        hexagon16.material.SetColor("_EmissionColor", color);
        hexagon17.material.color = color;
        hexagon17.material.SetColor("_EmissionColor", color);
        hexagon18.material.color = color;
        hexagon18.material.SetColor("_EmissionColor", color);
        hexagon19.material.color = color;
        hexagon19.material.SetColor("_EmissionColor", color);
        hexagon20.material.color = color;
        hexagon20.material.SetColor("_EmissionColor", color);
        hexagon21.material.color = color;
        hexagon21.material.SetColor("_EmissionColor", color);
        hexagon22.material.color = color;
        hexagon22.material.SetColor("_EmissionColor", color);


    }
}
