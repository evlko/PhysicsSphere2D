using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float mass;
    public float hspeed;
    public float vspeed;
    public float speed;
    public float size;
    public bool showLine;
    LineDrawer lineDrawer;
    
    void Start()
    {
        UpdateSpeed();
        lineDrawer = new LineDrawer();
        size = GetComponent<Transform>().localScale.x;
        DrawSpeed();
    }

    // Function to scale the sphere
    public void UpdateSize(){
        GetComponent<Transform>().localScale = new Vector2(size, size);
    }

    // Function to update speed value
    public void UpdateSpeed(){
        speed = Mathf.Sqrt(hspeed * hspeed + vspeed * vspeed);
    }
    
    // Function to draw the speed vector
    public void DrawSpeed(){
        if(showLine){
            Vector3 startPoint = GetComponent<Transform>().localPosition;
            Vector3 endPoint = new Vector3(startPoint.x + hspeed * 10, startPoint.y + vspeed * 10, 0);
            Color color = GetComponent<SpriteRenderer>().color;
            lineDrawer.DrawLineInGameView(startPoint, endPoint, color);
        }
    }

    // Function to destroy the drawing of speed vector
    public void DestroySpeed(){
        lineDrawer.Destroy();
    }
}
