using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera camera;
    public float minSize, maxSize;
    float currentSize = 0;
    
    void Start()
    {
        currentSize = camera.orthographicSize;
    }

    public void ChangeCameraSize(int step){
        if((step < 0 && currentSize > minSize ) || (step > 0 && currentSize < maxSize)){
            currentSize += step;
            camera.orthographicSize = currentSize;
        }
    }
}
