using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodName : MonoBehaviour
{
    public static string topText;
    public static string[] nutritionalValue = new string[4];

    public Text[] nutrition = new Text[3];
    public Text topmostText;

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<ButtonNavigate>().isActive)
            topmostText.text = "DEMERITS";
        else
            topmostText.text = topText;
        for(int i=0;i<3;i++)
        {
            nutrition[i].text = nutritionalValue[i];
        }
    }
}
