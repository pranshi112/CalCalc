using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
public class ImageRecognition : MonoBehaviour
{    
    private ARTrackedImageManager _aRTrackedImageManager;
    public GameObject mainCanvas;
    [HideInInspector]
    public int flag = 0;

    private void Awake()
    {
        _aRTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        _aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        _aRTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        if(flag==0)
        {
            mainCanvas.SetActive(true);
            flag++;
        }

        foreach (var trackedImage in args.updated)
        {
            if(trackedImage.referenceImage.name == "Samosa")
            {
                FoodName.topText = "Samosa";
                FoodName.nutritionalValue[0] = "252";
                FoodName.nutritionalValue[1] = "35g";
                FoodName.nutritionalValue[2] = "9g";
                FoodName.nutritionalValue[3] = "8g";
            }
        }
            
    }
}
