using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToggleCursorImage : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Texture2D secondCursorImage;
    [SerializeField] private Vector2 hotspot;
    [SerializeField] private Sprite GlovesOpen;

    private Image image;

    private CursorMode cursorMode = CursorMode.Auto;
    private int clickCount = 0;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        clickCount++;

        if (clickCount == 1)
        {
            image.sprite = GlovesOpen;
        }
        if (clickCount == 2)
        {
            Cursor.SetCursor(secondCursorImage, hotspot, CursorMode.Auto);
            Cursor.SetCursor(secondCursorImage, hotspot, CursorMode.ForceSoftware);
        }
    }
}
