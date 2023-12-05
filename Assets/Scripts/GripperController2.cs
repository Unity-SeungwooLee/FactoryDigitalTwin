using System.Collections;
using UnityEngine;

public class GripperController2 : MonoBehaviour
{
    public float speed = 0.000001f;
    private Vector3 startPosition;
    private Vector3 endPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(0f, 0.00032f, -0.000074f);
        endPosition = new Vector3(0f, 0.00032f, -0.000293f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            MoveObject(Vector3.forward);  // G Ű�� ������ ���� �� ���������� �̵�
        }
        else if (Input.GetKey(KeyCode.H))
        {
            MoveObject(Vector3.back);  // H Ű�� ������ ���� �� ���������� �̵�
        }
    }

    void MoveObject(Vector3 direction)
    {
        float step = speed * Time.deltaTime;
        transform.localPosition += direction * step;
    }
}
