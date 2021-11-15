using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AmbientLightEstimation : MonoBehaviour
{
    // We need this variable so that we can get each frame of the app, get the lightening values from that frame,
    // and determine case of low light from it.
    public ARCameraManager cameraManager;
    public GameObject warningText;

    // this function is used to subscribe to the frameReceived event and is called when the attached GameObject is toggled.
    private void OnEnable()
    {
        // The function, OnCameraFrameReceived is a listener method and
        // will be called for each frame that the camera receives through frameReceived event.
        // So this function will be called over and over again.
        cameraManager.frameReceived += OnCameraFrameReceived;
    }

    void OnCameraFrameReceived(ARCameraFrameEventArgs camFrameEvent)
    {
        // getting the light estimation data for each frame. We will get the brightness value and the color temperature value from this light estimation data.
        ARLightEstimationData led = camFrameEvent.lightEstimation;

        if(led.averageBrightness.Value<0.1f)
                warningText.SetActive(true);
            else
                warningText.SetActive(false);
    }

    // to unsubscribe from the event in case our light is disabled for some reason.
    private void OnDisable()
    {
        cameraManager.frameReceived -= OnCameraFrameReceived;
    }
}
