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

    //����
    public int bodyTwoAngle;
    public int bodyThreeAngle;
    public int bodyFourAngle;
    public int bodyFiveAngle;
    public int bodySixAngle;
    public int bodySevenAngle;
    // Start is called before the first frame update
    void Start()
    {
        bodyTwo.text = "Body2     " + ((int)body2.transform.localRotation.eulerAngles.z).ToString() + "��";
        bodyThree.text = "Body3     " + ((int)body3.transform.localRotation.eulerAngles.x).ToString() + "��";
        bodyFour.text = "Body4     " + ((int)body4.transform.localRotation.eulerAngles.x).ToString() + "��";
        bodyFive.text = "Body5     " + ((int)body5.transform.localRotation.eulerAngles.y).ToString() + "��";
        bodySix.text = "Body6     " + ((int)body6.transform.localRotation.eulerAngles.x -270).ToString() + "��";
        bodySeven.text = "Body7     " + ((int)body7.transform.localRotation.eulerAngles.y).ToString() + "��" ;
    }

    void Update()
    {
        //Debug.Log(body2.transform.rotation.eulerAngles);
        bodyTwo.text = "Body2     " + ((int)body2.transform.localRotation.eulerAngles.z).ToString() + "��";
        //Debug.Log(body3.transform.rotation.eulerAngles);
        bodyThree.text = "Body3     " + ((int)body3.transform.localRotation.eulerAngles.x).ToString() +"��";
        //Debug.Log(body4.transform.rotation.eulerAngles);
        bodyFour.text = "Body4     " + ((int)body4.transform.localRotation.eulerAngles.x).ToString() +"��";
        //Debug.Log(body5.transform.rotation.eulerAngles);
        bodyFive.text = "Body5     " + ((int)body5.transform.localRotation.eulerAngles.y).ToString() +"��";
        //Debug.Log(body6.transform.rotation.eulerAngles);
        bodySix.text = "Body6     " + ((int)body6.transform.localRotation.eulerAngles.x -270).ToString() +"��";
        //Debug.Log(body7.transform.rotation.eulerAngles);
        bodySeven.text = "Body7     " + ((int)body7.transform.localRotation.eulerAngles.y).ToString() +"��";
    }
}

