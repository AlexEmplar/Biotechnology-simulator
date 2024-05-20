using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageClickSprite : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Sprite spriteToUse;
    private Image image;
    private bool spriteOnImage = false;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!spriteOnImage)
        {
            image.sprite = spriteToUse;
            image.color = new Color(image.color.r, image.color.g, image.color.b, 255);
            spriteOnImage = true;
        }
        else
        {
            image.transform.Rotate(Vector3.forward * 30);
        }
    }
}
