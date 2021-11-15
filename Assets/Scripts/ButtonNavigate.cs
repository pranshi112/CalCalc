using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ButtonNavigate : MonoBehaviour
{
    public GameObject[] uiElements;
    public GameObject demerits;
    [HideInInspector]
    public bool isActive = true;
    public GameObject button1;
    public GameObject button2;

    public void MoreInfo()
    {
        if(isActive)
        {
            foreach (var item in uiElements)
                item.SetActive(false);
            demerits.SetActive(true);
            button1.SetActive(false);
            button2.SetActive(true);
            isActive = false;
        }            
        else
        {
            foreach (var item in uiElements)
                item.SetActive(true);
            demerits.SetActive(false);
            button1.SetActive(true);
            button2.SetActive(false);
            isActive = true;
        }
    }
}
