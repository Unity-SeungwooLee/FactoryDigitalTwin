using UnityEngine;
using System;
using System.Collections;

public class ObjectMovement : MonoBehaviour
{
    public GameObject gripper;  // �ܺο��� Unity �����Ϳ��� ������ �� �ִ� GameObject ����

    private Vector3 originalPosition;
    private bool isMoving = false;
    private float moveSpeed = 0.02f;
    private float moveDuration = 3.0f;

    void Start()
    {
        // �ʱ� ��ġ ����
        originalPosition = gripper.transform.localPosition;
    }

    void Update()
    {
        // gŰ�� ������ gripper ������Ʈ�� �������� ������Ʈ�� �̵���Ű�� ����
        if (Input.GetKeyDown(KeyCode.G) && !isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveObject(gripper.transform));
        }

        // hŰ�� ������ gripper ������Ʈ�� �������� ������Ʈ�� �ʱ� ��ġ�� �ǵ����� ����
        if (Input.GetKeyDown(KeyCode.H) && !isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveBack(gripper.transform));
        }
    }

    // ������Ʈ�� �̵���Ű�� �ڷ�ƾ
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

    // ������Ʈ�� �ʱ� ��ġ�� �ǵ����� �ڷ�ƾ
    IEnumerator MoveBack(Transform referenceTransform)
    {
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            gripper.transform.position = Vector3.Lerp(transform.position, referenceTransform.TransformPoint(originalPosition), elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // ������Ʈ�� ��Ȯ�� �ʱ� ��ġ�� �����ϵ��� ����
        gripper.transform.position = referenceTransform.TransformPoint(originalPosition);
        isMoving = false;
    }
}
