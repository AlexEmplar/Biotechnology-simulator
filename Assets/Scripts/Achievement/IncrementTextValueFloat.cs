using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IncrementTextValueFloat : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private float incrementAmount;
    [SerializeField] private float maxAmount;
    private string[] textList = {
        "2.50",
        "2.40",
        "2.30",
        "2.20",
        "2.10",
        "2.00",
        "1.90",
        "1.80",
        "1.70",
        "1.60",
        "1.50",
        "1.40",
        "1.30",
        "1.20",
        "1.10",
        "1.00",
        "0.90",
        "0.80",
        "0.70",
        "0.60",
        "0.50",
        "0.40",
        "0.30",
        "0.20",
        "0.10",
        "0.00"
    };
    private int hiddenFloat = 0;
    private int hiddenMaxAmount = 25;
    private int hiddenMinAmount = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (hiddenFloat > hiddenMinAmount)
            {
                hiddenFloat -= 1;
                IncrementValue(hiddenFloat);
            }
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (hiddenFloat < hiddenMaxAmount)
            {
                hiddenFloat += 1;
                IncrementValue(hiddenFloat);
                print("down");
            }
            else
            {
                print("Too small");
            }
        }
    }

    private void IncrementValue(int something)
    {

            valueText.text = textList[something];
    }
}