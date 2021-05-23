using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SystemChecker : MonoBehaviour
{
    public List<Sphere> spheres;
    public bool simPlaying = false;

    // Start the simulation. The time if off by default.
    void Start()
    {
        Time.timeScale = 0f;
        InvokeRepeating("DebugSystem", 0.1f, 5f);
    }

    // Function to debug Kinematic Energy in the system
    void DebugSystem(){
        float result = 0;
        for (int i = 0; i < spheres.Count; i++){
            result = result + ((spheres[i].mass * spheres[i].speed * spheres[i].speed)/2);
        }

        print("Energy: " + result);
    }

    // Function to reload the simulation
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
