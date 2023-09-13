using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI SWEnum;
    [SerializeField] private TextMeshProUGUI SBEnum;
    [SerializeField] private TextMeshProUGUI BWEnum;
    [SerializeField] private TextMeshProUGUI TEnum;
    [SerializeField] private TextMeshProUGUI PropNum;

    public void UpdateUI(float one, float two, float three, float four, float five)
    {
        SWEnum.text = one.ToString("F2");
        SBEnum.text = two.ToString("F2");
        BWEnum.text = three.ToString("F2");
        TEnum.text = four.ToString("F2");
        PropNum.text = five.ToString("F2");
    }
}
