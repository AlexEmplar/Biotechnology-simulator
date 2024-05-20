using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHighlighter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Color highlightColor = Color.gray;
    [SerializeField] private float highlightDuration = 0.1f;

    [SerializeField] private Image buttonImage;
    private Color originalColor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonImage.color = highlightColor;
        //print("Lol");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonImage.color = originalColor;
        //print("Kek");
    }
}
