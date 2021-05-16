using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float mass;
    public float hspeed;
    public float vspeed;
    public float speed;
    public bool showLine;
    LineDrawer lineDrawer;
    // Start is called before the first frame update
    void Start()
    {
        UpdateSpeed();
        lineDrawer = new LineDrawer();
        DrawSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSpeed(){
        speed = Mathf.Sqrt(hspeed * hspeed + vspeed * vspeed);
    }
    
    public void DrawSpeed(){
        if(showLine){
            Vector3 startPoint = GetComponent<Transform>().localPosition;
            Vector3 endPoint = new Vector3(startPoint.x + hspeed * 10, startPoint.y + vspeed * 10, 0);
            Color color = GetComponent<SpriteRenderer>().color;
            lineDrawer.DrawLineInGameView(startPoint, endPoint, color);
        }
    }

    public void DestroySpeed(){
        lineDrawer.Destroy();
    }
}
