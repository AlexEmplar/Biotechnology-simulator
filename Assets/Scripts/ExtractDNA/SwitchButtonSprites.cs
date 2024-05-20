using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SwitchButtonSprites : MonoBehaviour
{
    [SerializeField] private Sprite firstSprite;
    [SerializeField] private Sprite secondSprite;
    private Image buttonImage;

    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
        buttonImage.sprite = firstSprite;
        button1.SetActive(false);
        button2.SetActive(false);
    }

    public void SwitchSprites()
    {
        if (buttonImage.sprite == firstSprite)
        {
            buttonImage.sprite = secondSprite;
            button1.SetActive(true);
            button2.SetActive(true);
        }
        else
        {
            buttonImage.sprite = firstSprite;
            button1.SetActive(false);
            button2.SetActive(false);
        }
    }
}
