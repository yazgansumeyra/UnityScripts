using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeColorModifier : MonoBehaviour
{
    public MeshRenderer cube;
    public Slider red;
    public Slider green;
    public Slider blue;

    // Update is called once per frame
    public void OnEdit()
    {
        Color color = cube.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;

        cube.material.color = color;

        float emission = Mathf.PingPong(Time.time, 1.0f);
        Color finalColor = color * (3f);

        // cube.material.SetColor("_EmissionColor", color);
        cube.material.SetColor("_EMISSION", new Color(0.0927F, 0.4852F, 0.2416F, 0.42F));
        cube.material.EnableKeyword("_EMISSION");


    }
}
