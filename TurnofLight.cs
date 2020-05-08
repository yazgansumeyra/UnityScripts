using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnofLight : MonoBehaviour
{
    bool deactivate = false;
    float startTime;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = (Time.time - startTime);

        if ((t >= 2) && (deactivate == false))
        {
            GetComponent<Light>().enabled = false;
            deactivate = true;

        }


    }
}
