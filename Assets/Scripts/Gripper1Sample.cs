using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gripper1Sample : MonoBehaviour
{
    private bool isGrabbing = false;
    private bool isMoving = false;
    private GameObject grabbedObject;
    private Rigidbody grabbedObjectRigidbody;
    private FixedJoint joint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!isGrabbing)
            {
                StartCoroutine(MoveGripper(0.000066f, 3f));
            }
            else
            {
                // Release the grabbed object
                ReleaseObject();
            }
        }
        else if (Input.GetKeyDown(KeyCode.H) && !isMoving)
        {
            StartCoroutine(MoveGripper(0.0003f, 3f));
        }
    }

    IEnumerator MoveGripper(float targetPosition, float duration)
    {
        isMoving = true;

        Vector3 startPosition = transform.localPosition;
        Vector3 target = new Vector3(0f, 0.000319f, targetPosition);

        float elapsedTime = 0f;
        float thresholdDistance = 0.01f;

        while (elapsedTime < duration)
        {
            transform.localPosition = Vector3.Lerp(startPosition, target, elapsedTime / duration);

            // Check the distance to the target and exit the coroutine if close enough
            if (Vector3.Distance(transform.localPosition, target) < thresholdDistance)
            {
                break;
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = target;

        isMoving = false;

        // If grabbing, move the grabbed object along with the gripper
        if (isGrabbing && grabbedObject != null)
        {
            MoveGrabbedObject();
        }
    }

    void MoveGrabbedObject()
    {
        // Move the grabbed object along with the gripper
        grabbedObject.transform.position = transform.position;
    }

    void ReleaseObject()
    {
        if (grabbedObject != null)
        {
            // Temporarily disable physics interactions of the gripper
            GetComponent<Rigidbody>().isKinematic = true;


            Destroy(joint);
            //움직임 멈추게
            //grabbedObjectRigidbody.isKinematic = false;
            grabbedObjectRigidbody.velocity = Vector3.zero; // Stop any residual movement

            // Release the grabbed object and restore its original physics properties
            //grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObject = null;
            grabbedObjectRigidbody = null;
            joint = null;

            // Re-enable physics interactions of the gripper
            GetComponent<Rigidbody>().isKinematic = false;
        }

        isGrabbing = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the gripper collides with a grabbable object
        if (other.CompareTag("Grabbable") && !isGrabbing)
        {
            // Grab the object
            GrabObject(other.gameObject);
        }
    }

    void GrabObject(GameObject obj)
    {
        isGrabbing = true;
        grabbedObject = obj;
        grabbedObjectRigidbody = grabbedObject.GetComponent<Rigidbody>();
        // Make the object kinematic to avoid physics issues during grabbing
        //grabbedObjectRigidbody.isKinematic = true;


        // Make the object kinematic to avoid physics issues during grabbing
        grabbedObjectRigidbody.isKinematic = true;
        // Attach a fixed joint to connect the gripper and the grabbed object
        joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = grabbedObjectRigidbody;

        // Make the object kinematic to avoid physics issues during grabbing
        //grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
    }
}
