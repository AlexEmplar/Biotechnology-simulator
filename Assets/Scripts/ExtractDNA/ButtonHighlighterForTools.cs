using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHighlighterForTools : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Color highlightColor = Color.gray;
    [SerializeField] private float highlightDuration = 0.1f;

    [SerializeField] private Image buttonImage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonImage.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonImage.color = Color.white;
    }
}
