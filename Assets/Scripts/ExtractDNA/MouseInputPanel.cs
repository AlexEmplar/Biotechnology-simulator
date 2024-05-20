using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseInputPanel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject explainPanel;

    [SerializeField] private Image buttonImage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        explainPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        explainPanel.SetActive(false);
    }
}
