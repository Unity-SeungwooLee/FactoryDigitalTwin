using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControllerSW : MonoBehaviour
{
    public float speed = 20f;
    public float maxRotationZ = 5f; // 최대 회전 각도

    public GameObject body2;
    public GameObject body3;
    public GameObject body4;
    public GameObject body5;
    float accumulatedRotationZ = 0f; // Accumulated rotation for the Z axis

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.K))
        {
            accumulatedRotationZ = 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body2.transform.Rotate(new Vector3(0, 0, accumulatedRotationZ));
        }

        if (Input.GetKey(KeyCode.D))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body2.transform.Rotate(new Vector3(0, 0, -accumulatedRotationZ));
        }

        if (Input.GetKey(KeyCode.W))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body3.transform.Rotate(new Vector3(accumulatedRotationZ, 0, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body3.transform.Rotate(new Vector3(-accumulatedRotationZ, 0, 0));
        }

        if (Input.GetKey(KeyCode.J))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body4.transform.Rotate(new Vector3(accumulatedRotationZ, 0, 0));
        }

        if (Input.GetKey(KeyCode.L))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body4.transform.Rotate(new Vector3(-accumulatedRotationZ, 0, 0));
        }

        if (Input.GetKey(KeyCode.I))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body5.transform.Rotate(new Vector3(0, accumulatedRotationZ, 0));
        }

        if (Input.GetKey(KeyCode.K))
        {
            accumulatedRotationZ += speed * Time.deltaTime * 0.001f;

            if (accumulatedRotationZ > maxRotationZ)
            {
                accumulatedRotationZ = maxRotationZ;
            }
            Debug.Log(accumulatedRotationZ);
            body5.transform.Rotate(new Vector3(0, -accumulatedRotationZ, 0));
        }
    }
}