using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleDatasets : MonoBehaviour
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

    public Text myText;
    int i = 0;
    public int arrayCount = 0;
    public int arrayLength = 0;

    float startTime;

    bool deactivate = false;
    bool deactivate1 = false;
    bool deactivate2 = false;
    bool deactivate3 = false;
    float map(float x, float in_min, float in_max, float out_min, float out_max)
    {
        return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    }

    string[] textArray = new string[] { "CO2 Concentration", "Global Plastic Production" };
    double[] coEmissionArray = new double[] { 2.160510197,2.139605747,2.123813009,2.358210671,2.339404843
,2.396326707,2.500781616,2.469994891,2.439855817,2.41008414,2.360057218,2.486678432,2.547321549
,2.54211613,2.554579789,2.574299828,2.702241992,2.695824418,2.664424165,2.646895355
,2.621646821,2.605945725,2.668793008,2.771452876,2.862933943,2.854074247,2.847875564,2.927720008
,2.910069566,2.914119739,3.661627909,3.504761889,3.452835055,3.40645805,3.368251269,3.31474663
,3.837698725,3.66270621,3.725384308,3.785111073,3.90407311,3.912871298,4.0471461,4.187612991,4.355667988
,4.618766735,4.38149662,4.699626284,4.916539494,5.173033812,5.419337557,5.110936717,5.047744534,4.975748011
,5.943133702,5.516170255,5.884017899,5.72776343,5.561967596,6.11507735,6.776697517
,6.988225248,6.69234302,7.03974761,7.491925128,7.852820684,8.003363255,8.127329964,7.884686245
,8.181038065,8.263323944,8.655466728,9.017491487,9.26143737,8.900550654,9.292276298,9.174811016,9.240115359,8.976316617
,8.933876996,9.631285775,10.01048422,9.987086616,10.28180646,9.904704957,9.686748988,9.502352707,9.652380155,9.936374757,10.18688053,10.31760168
,10.42775945,10.1066774,8.958951209,10.15141351,10.13957561,10.3180128,10.4801447,10.39491734,11.02324002,11.04703556
,10.69973843,11.00219688,10.97949699,10.92385428,10.96155318,11.24662329,11.63956942,11.24634114,11.24115561
,11.23628978,11.41682092,10.7477751,11.67306072,11.23216457,11.29783532,11.64889238,11.49236767,10.70842758
,10.45104033,10.72462094,7.245593832,9.637910408,10.17370668,10.59103907,9.958201723,5.437124235,10.26105189,9.590806657,10.06048634,9.597775846
,8.926852913,8.53310123,8.416530561,9.048388404,9.138060883,9.621226579,9.881384867,9.415979262,9.427187756,9.850406351,9.709654635
,9.656591678,9.315377098,9.004950384,8.483146187,8.829081339,9.285807573,9.503714806,9.624059465,9.886991733,10.76297036,10.42546602,10.63222912
,10.84908095,11.2793852,11.18302223,11.06284939,10.72847991,10.48967406,11.13837219,11.15015823,11.15133932,11.26501241,11.26825054
,11.45628042,11.31362762,10.77868001,10.98821057,11.33657936,11.72963346,11.83284791,11.5815545,11.76412724,10.9912723,10.73165758,10.64095934
,10.74192038,10.74786065,11.45554472,10.29114168,9.960762472,9.738500406,9.683602017,9.383654907,9.910862872,10.04970431,10.08070007
,10.02929723,10.1988619,10.51123712,10.62131663,10.32279146,10.05026936,9.957614752,9.77665603,10.11909215,9.640390903,9.69317243
,9.5410479,9.619224686,9.736836803,9.436408323,9.593803944,9.571881291,9.454830655,9.335955512,9.107304032,8.777084521
,7.885589505,8.090977674,7.362444853,7.590167302,7.39053787,6.747466712,6.463018745,6.058056283,5.812897782};

    double[] co2Array = new double[] {283.12,283.95 ,283.53 ,281.83 ,282.57 ,281.11 ,279.36 ,275.07 ,271.11 ,273.78 ,
276.69  ,278.02 ,276.66 ,276.32 ,277.36 ,277.64 ,278.31 ,276.81 ,277.6  ,277.23 ,277.16 ,276.4  ,277.86 ,280.24 ,
273.07  ,281.62 ,281.35 ,282.8  ,284.43 ,281.36 ,285.91 ,284.45 ,284.15 ,283.65 ,281.58 ,283.53 ,283.18 ,283.62 ,
286.84  ,284.0  ,287.13 ,288.05 ,285.57 ,283.16 ,286.63 ,287.17 ,285.35 ,286.65 ,285.05 ,288.76 ,287.16 ,286.66 ,291.56 ,
289.33  ,287.77 ,292.46 ,289.49 ,288.12 ,294.34 ,292.34 ,290.92 ,295.17 ,295.09 ,293.49 ,296.16 ,294.22 ,295.61 ,
295.99  ,299.02 ,298.48 ,301.5  ,297.87 ,298.36 ,301.3  ,300.7  ,301.92 ,303.85 ,304.61 ,301.88 ,304.69 ,304.84 ,
306.84  ,305.62 ,305.74 ,308.26 ,307.11 ,308.35 ,306.32 ,308.3  ,307.41 ,311.07 ,310.83 ,310.38 ,309.77 ,312.37 ,
312.36  ,310.94 ,312.26 ,311.61 ,311.57 ,309.69 ,312.83 ,312.18 ,312.73 ,314.71 ,315.34 ,315.34 ,315.34 ,315.97 ,
316.91  ,317.64 ,318.45 ,318.99 ,319.62 ,320.04 ,321.38 ,322.16 ,323.04 ,324.62 ,325.68 ,326.32 ,327.45 ,329.68 ,
330.18  ,331.11 ,332.04 ,333.83 ,335.4  ,336.84 ,338.75 ,340.11 ,341.45 ,343.05 ,344.65 ,346.12 ,347.42 ,349.19 ,
351.57  ,353.12 ,354.39 ,355.61 ,356.45 ,357.1  ,358.83 ,360.82 ,362.61 ,363.73 ,366.7  ,368.38 ,369.55 ,371.14 ,373.28 ,
375.8   ,377.52 ,379.8  ,381.9  ,383.79 ,385.6  ,387.43 ,389.9  ,391.65 ,393.85 ,396.52 ,398.65 ,400.83 ,404.24 ,
406.55  ,408.52 ,};

    double[] plasticArray = new double[] {0 ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,
0 ,0 ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,
0 ,0 ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,
0 ,0 ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,
0 ,0 ,2000000 ,2000000 ,2000000 ,3000000 ,3000000 ,4000000 ,5000000 ,5000000 ,6000000  ,7000000 ,8000000,9000000    ,11000000   ,13000000   ,15000000   ,17000000   ,20000000   ,23000000   ,27000000   ,
32000000 ,35000000 ,38000000 ,44000000 ,51000000 ,52000000 ,46000000 ,54000000 ,59000000 ,64000000  ,71000000 ,70000000 ,72000000 ,73000000 ,80000000 ,86000000 ,90000000 ,96000000   ,
104000000,110000000 ,114000000 ,120000000  ,124000000 ,132000000,137000000 ,151000000 ,156000000 ,168000000  ,
180000000 ,188000000 ,202000000 ,213000000  ,218000000 ,231000000,241000000  ,256000000 ,263000000 ,280000000 ,295000000 ,281000000  ,288000000  ,313000000 ,325000000  ,338000000  ,352000000  ,
367000000 ,381000000 ,381000000 };

    void Start()
    {
        startTime = Time.time;
        for (int i = 0; i < coEmissionArray.Length; i++)
        {
            coEmissionArray[i] = map((float)coEmissionArray[i], 0, 12, 1, 0);

        }
        for (int i = 0; i < co2Array.Length; i++)
        {
            co2Array[i] = map((float)co2Array[i], 272, 409, 1, 0);

        }
        for (int i = 0; i < plasticArray.Length; i++)
        {
            plasticArray[i] = map((float)plasticArray[i], 0, 381000000, 1, 0);

        }

    }
    void Update()
    {
        Color color = hexagon.material.color;
        float t = (Time.time - startTime);
        //hexagon.material.color = Color.Lerp(startColor, endColor, t);
        // Debug.Log(t);
        // Debug.Log((int)t % 10);

        if (((int)t % 2 == 0) && (deactivate == false) && ((int)t != 0))
        {
            //Debug.Log("time");
            deactivate = true;
            switch (arrayCount)
            {
                case 0:
                    color.r = 1f;

                    color.g = (float)coEmissionArray[i];
                    color.b = (float)coEmissionArray[i];
                    arrayLength = coEmissionArray.Length;
                    break;
                case 1:
                    color.b = 1f;

                    color.g = (float)co2Array[i];
                    color.r = (float)co2Array[i];
                    arrayLength = co2Array.Length;

                    break;
                case 2:
                    color.g = 1f;

                    color.b = (float)plasticArray[i];
                    color.r = (float)plasticArray[i];
                    arrayLength = plasticArray.Length;

                    break;



            }


            /*
            if (color.r < 0.3)
            {
                // hexagon.material.color = color;
                //  hexagon.material.SetColor("_EmissionColor", color);
                Debug.Log("> 0.2");
            }
            else if (color.r < 0.6)
            {
                // hexagon.material.color = color;
                //  hexagon.material.SetColor("_EmissionColor", color);
                Debug.Log("> 0.4");

            }
            else if (color.r < 0.9)
            {
                //hexagon.material.color = color;
                // hexagon.material.SetColor("_EmissionColor", color);
                Debug.Log("> 0.8");

            }
            */
            ChangeColor(color);
            //This part is for skiping looking every element in the array
            i += 8;
            if (i >= arrayLength)
            {
                i = 0;
                SetText(textArray[arrayCount]);
                arrayCount += 1;
                //Debug.Log("end");

            }
        }
        else if (((int)t % 2 != 0))
        {

            //  hexagon.material.color = color;
            // hexagon.material.SetColor("_EmissionColor", color);
            deactivate = false;

        }

    }

    public void ChangeColor(Color color)
    {
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

    void SetText(string text)
    {
        myText.text = text;
    }
}

