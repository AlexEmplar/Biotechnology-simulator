using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IncrementTextValue : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private float incrementAmount;
    [SerializeField] private float maxAmount;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            int currentValue = int.Parse(valueText.text);
            if ((float)currentValue < maxAmount)
            {
                IncrementValue(incrementAmount);
            }
            else
            {
                print("Too big");
            }
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            int currentValue = int.Parse(valueText.text);
            if ((float)currentValue > 0)
            {
                IncrementValue(-incrementAmount);
            }
            else
            {
                print("Too small");
            }
        }
    }

    private void IncrementValue(float amount)
    {
        int currentValue = int.Parse(valueText.text);
        float newValue = currentValue + amount;
        if (newValue <= 0.001)
        {
            valueText.text = "000";
        }
        else
        {
            valueText.text = newValue.ToString();
        }
    }
}
