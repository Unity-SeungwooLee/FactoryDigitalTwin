using UnityEngine;
using System;
using System.Collections;

public class ObjectMovement : MonoBehaviour
{
    public GameObject gripper;  // 외부에서 Unity 에디터에서 지정할 수 있는 GameObject 변수

    private Vector3 originalPosition;
    private bool isMoving = false;
    private float moveSpeed = 0.02f;
    private float moveDuration = 3.0f;

    void Start()
    {
        // 초기 위치 저장
        originalPosition = gripper.transform.localPosition;
    }

    void Update()
    {
        // g키를 누르면 gripper 오브젝트를 기준으로 오브젝트를 이동시키기 시작
        if (Input.GetKeyDown(KeyCode.G) && !isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveObject(gripper.transform));
        }

        // h키를 누르면 gripper 오브젝트를 기준으로 오브젝트를 초기 위치로 되돌리기 시작
        if (Input.GetKeyDown(KeyCode.H) && !isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveBack(gripper.transform));
        }
    }

    // 오브젝트를 이동시키는 코루틴
    IEnumerator MoveObject(Transform referenceTransform)
    {
        float elapsedTime = 0f;
        Debug.Log("Coroutine Start");

        while (elapsedTime < moveDuration)
        {
            gripper.transform.Translate(new Vector3(0f, 0f, moveSpeed), referenceTransform);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isMoving = false;
    }

    // 오브젝트를 초기 위치로 되돌리는 코루틴
    IEnumerator MoveBack(Transform referenceTransform)
    {
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            gripper.transform.position = Vector3.Lerp(transform.position, referenceTransform.TransformPoint(originalPosition), elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 오브젝트가 정확히 초기 위치에 도달하도록 보정
        gripper.transform.position = referenceTransform.TransformPoint(originalPosition);
        isMoving = false;
    }
}
