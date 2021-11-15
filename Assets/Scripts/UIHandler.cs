using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    private bool isUIActive = true;
    private GameObject canvas;

    private void Start()
    {
        canvas = FindObjectOfType<ImageRecognition>().mainCanvas;
    }

    public void HideUI()
    {
        if(FindObjectOfType<ImageRecognition>().flag==1)
        {
            if (isUIActive)
            {
                canvas.SetActive(false);
                isUIActive = false;
            }
            else
            {
                canvas.SetActive(true);
                isUIActive = true;
            }
        }
    }
}
