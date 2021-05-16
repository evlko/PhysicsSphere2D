using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemChecker : MonoBehaviour
{
    public Sphere[] spheres;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DebugSystem", 0.1f, 5f);
    }

    void DebugSystem(){
        float result = 0;
        for (int i = 0; i < spheres.Length; i++){
            result = result + (spheres[i].mass * spheres[i].speed);
        }

        print("Impulse: " + result);

        result = 0;
        for (int i = 0; i < spheres.Length; i++){
            result = result + ((spheres[i].mass * spheres[i].speed * spheres[i].speed)/2);
        }

        print("Energy: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
