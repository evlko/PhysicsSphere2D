using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Sphere thisSphere;
    Transform thisTransform;
    void Start()
    {
        thisSphere = GetComponent<Sphere>();
        thisTransform = GetComponent<Transform>();
    }

    // Function to check the collision of two spheres. Only one of them should have this script. 
    void OnCollisionEnter2D(Collision2D other) {
        Sphere otherSphere = other.gameObject.GetComponent<Sphere>();
        Transform otherTransform = other.gameObject.GetComponent<Transform>();

        float dx = thisTransform.localPosition.x - otherTransform.localPosition.x;
        float dy = thisTransform.localPosition.y - otherTransform.localPosition.y;
        float coll_ang =  Mathf.Atan2(dy, dx);

        float sp1 = Mathf.Sqrt(thisSphere.hspeed * thisSphere.hspeed + thisSphere.vspeed * thisSphere.vspeed);
        float sp2 = Mathf.Sqrt(otherSphere.hspeed * otherSphere.hspeed + otherSphere.vspeed * otherSphere.vspeed);

        float dir1 = Mathf.Atan2(thisSphere.vspeed, thisSphere.hspeed);
        float dir2 = Mathf.Atan2(otherSphere.vspeed, otherSphere.hspeed);

        float xspeed_1 = sp1 * Mathf.Cos(dir1 - coll_ang);
        float yspeed_1 = sp1 * Mathf.Sin(dir1 - coll_ang);
        float xspeed_2 = sp2 * Mathf.Cos(dir2 - coll_ang);
        float yspeed_2 = sp2 * Mathf.Sin(dir2 - coll_ang);

        float fxspeed_1 = ((thisSphere.mass - otherSphere.mass) * xspeed_1 + (otherSphere.mass + otherSphere.mass) * xspeed_2) / (thisSphere.mass + otherSphere.mass);
        float fxspeed_2 = ((thisSphere.mass + thisSphere.mass) * xspeed_1 + (otherSphere.mass - thisSphere.mass) * xspeed_2) / (thisSphere.mass + otherSphere.mass);
        float fyspeed_1 = yspeed_1;
        float fyspeed_2 = yspeed_2;

        thisSphere.hspeed = Mathf.Cos(coll_ang) * fxspeed_1 + Mathf.Cos(coll_ang + Mathf.PI/2) * fyspeed_1;
        thisSphere.vspeed = Mathf.Sin(coll_ang) * fxspeed_1 + Mathf.Sin(coll_ang + Mathf.PI/2) * fyspeed_1;
        otherSphere.hspeed = Mathf.Cos(coll_ang) * fxspeed_2 + Mathf.Cos(coll_ang + Mathf.PI/2) * fyspeed_2;
        otherSphere.vspeed = Mathf.Sin(coll_ang) * fxspeed_2 + Mathf.Sin(coll_ang + Mathf.PI/2) * fyspeed_2;

        thisSphere.UpdateSpeed();
        otherSphere.UpdateSpeed();
        thisSphere.DrawSpeed();
        otherSphere.DrawSpeed();
    }
}
