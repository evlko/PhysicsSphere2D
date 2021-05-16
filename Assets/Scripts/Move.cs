using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Sphere sphere;
    Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GetComponent<Sphere>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector2(transform.localPosition.x + sphere.hspeed, transform.localPosition.y + sphere.vspeed);
    }
}
