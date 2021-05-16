using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public SystemChecker system;
    public InfoPanel infoPanel;
    Vector3 screenPoint;
    Vector3 offset;
    Sphere sphere;
    
    void Start(){
        sphere = GetComponent<Sphere>();
    }

    void OnMouseDown(){
        if (system.simPlaying == false){
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            infoPanel.ActivatePanel(true, sphere);
        }
    }
 
    void OnMouseDrag(){
        if (system.simPlaying == false){
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
            sphere.DrawSpeed();
        }  
    }
}
