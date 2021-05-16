using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float mass;
    public float hspeed;
    public float vspeed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        UpdateSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSpeed(){
        speed = Mathf.Sqrt(hspeed * hspeed + vspeed * vspeed);
    }
}
