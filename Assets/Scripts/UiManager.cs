using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public GameObject body2;
    public GameObject body3;
    public GameObject body4;
    public GameObject body5;
    public GameObject body6;
    public GameObject body7;

    //Body UI
    public TextMeshProUGUI bodyTwo;
    public TextMeshProUGUI bodyThree;
    public TextMeshProUGUI bodyFour;
    public TextMeshProUGUI bodyFive;
    public TextMeshProUGUI bodySix;
    public TextMeshProUGUI bodySeven;

    //°¢µµ
    public int bodyTwoAngle;
    public int bodyThreeAngle;
    public int bodyFourAngle;
    public int bodyFiveAngle;
    public int bodySixAngle;
    public int bodySevenAngle;
    // Start is called before the first frame update
    void Start()
    {
        bodyTwo.text = "Body2   " + body2.transform.eulerAngles.y.ToString();
        //Three.transform.rotation = Quaternion.Euler(270f, 0f, 0f);
        bodyThree.text = "Body3   " + body3.transform.eulerAngles.x.ToString();
        bodyFour.text = "Body4   " + body4.transform.rotation.eulerAngles.x.ToString();
        bodyFive.text = "Body5   " + body5.transform.rotation.eulerAngles.z.ToString();
        bodySix.text = "Body6   " + body6.transform.rotation.eulerAngles.x.ToString();
        bodySeven.text = "Body7   " + body7.transform.rotation.eulerAngles.y.ToString();
    }

    void Update()
    {
        //Debug.Log(body2.transform.rotation.eulerAngles);
        bodyTwo.text = "Body2   " + body2.transform.eulerAngles.y.ToString();
        //Debug.Log(body3.transform.rotation.eulerAngles);
        bodyThree.text = "Body3   " + (body3.transform.eulerAngles.x + -270).ToString();
        //Debug.Log(body4.transform.rotation.eulerAngles);
        bodyFour.text = "Body4   " + (body4.transform.rotation.eulerAngles.x + -270).ToString();
        //Debug.Log(body5.transform.rotation.eulerAngles);
        bodyFive.text = "Body5   " + (body5.transform.rotation.eulerAngles.x + -270).ToString();
        //Debug.Log(body6.transform.rotation.eulerAngles);
        bodySix.text = "Body6   " + (body6.transform.rotation.eulerAngles.x + -270).ToString();
        Debug.Log(body7.transform.rotation.eulerAngles);
        bodySeven.text = "Body7   " + body7.transform.rotation.eulerAngles.y.ToString();
    }
}

