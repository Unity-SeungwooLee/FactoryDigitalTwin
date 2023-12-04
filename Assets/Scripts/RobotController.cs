using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float speed = 10f;
    GameObject body2;
    float accumulatedRotationZ = 0f; // Accumulated rotation for the Z axis

    void Start()
    {
        body2 = GameObject.Find("Body2");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            accumulatedRotationZ += speed * Time.deltaTime; // Add to accumulated rotation
        }

        // Update body2's rotation with accumulated Z rotation
        body2.transform.rotation = Quaternion.Euler(body2.transform.rotation.eulerAngles + new Vector3(0, 0, accumulatedRotationZ));
    }
}