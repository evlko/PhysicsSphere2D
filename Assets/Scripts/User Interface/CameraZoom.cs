using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera camera;
    public float minSize, maxSize;
    float currentSize = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentSize = camera.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ZoomIn(){
        if (currentSize > minSize){
            currentSize -= 1;
        }
        camera.orthographicSize = currentSize;
    }

    public void ZoomOut(){
        if (currentSize < maxSize){
            currentSize += 1;
        }
        camera.orthographicSize = currentSize;
    }
}
