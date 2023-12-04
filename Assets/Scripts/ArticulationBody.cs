using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArticulationBody : MonoBehaviour
{
    public ArticulationBody body2;
    void Start()
    {
        body2 = GetComponent<ArticulationBody>();
    }
    void Update()
    {
        float tiltAngle = -25f;
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);

        //body2.anchorRotation = target;
    }
}
