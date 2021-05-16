using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SystemChecker : MonoBehaviour
{
    public Transform UIManager;
    public Transform spherePrefab;
    public List<Sphere> spheres;
    public List<Color> availabeColors;
    public bool simPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        InvokeRepeating("DebugSystem", 0.1f, 5f);
    }

    void DebugSystem(){
        float result = 0;
        for (int i = 0; i < spheres.Count; i++){
            result = result + ((spheres[i].mass * spheres[i].speed * spheres[i].speed)/2);
        }

        print("Energy: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSphere(){
        if (availabeColors.Count > 0){
            Transform newSphere;
            newSphere = Instantiate(spherePrefab, new Vector3(0, 0, 0), Quaternion.identity);
            newSphere.gameObject.GetComponent<SpriteRenderer>().color = availabeColors[0];
            newSphere.GetComponent<Drag>().system = GetComponent<SystemChecker>();
            newSphere.GetComponent<Drag>().infoPanel = UIManager.GetComponent<InfoPanel>();;
            availabeColors.RemoveAt(0);
            spheres.Add(newSphere.GetComponent<Sphere>());
            newSphere.name = spheres.Count.ToString();
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
