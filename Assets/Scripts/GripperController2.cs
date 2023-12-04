using System.Collections;
using UnityEngine;

public class GripperController2 : MonoBehaviour
{
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        // 초기화 또는 다른 설정이 필요하다면 이곳에 추가
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && !isMoving)
        {
            StartCoroutine(MoveGripper(-0.000074f, 3f));
        }
        else if (Input.GetKeyDown(KeyCode.H) && !isMoving)
        {
            StartCoroutine(MoveGripper(-0.000293f, 3f));
        }
    }

    IEnumerator MoveGripper(float targetPosition, float duration)
    {
        isMoving = true;

        Vector3 startPosition = transform.localPosition;
        Vector3 target = new Vector3(0f, 0.00032f, targetPosition);

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.localPosition = Vector3.Lerp(startPosition, target, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 보정을 위해 마지막에 명시적으로 위치를 설정
        transform.localPosition = target;

        isMoving = false;
    }
}
