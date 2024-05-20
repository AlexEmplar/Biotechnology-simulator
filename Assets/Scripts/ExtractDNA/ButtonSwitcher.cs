using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitcher : MonoBehaviour
{
    public Button firstButton;
    public Button secondButton;
    private Vector3 secondButtonPreviousPosition;
    private bool secondButtonMoved = false;

    void Start()
    {
        secondButtonPreviousPosition = secondButton.transform.position;

        //firstButton.onClick.AddListener(() =>
        //{
        //    if (secondButtonMoved)
        //    {
        //        firstButton.gameObject.SetActive(false);
        //        secondButton.transform.position = secondButtonPreviousPosition;
        //        secondButtonMoved = false;
        //    }
        //});

        secondButton.onClick.AddListener(() =>
        {
            if (!secondButtonMoved)
            {
                secondButton.transform.position = firstButton.transform.position;
                firstButton.gameObject.SetActive(false);
                secondButtonMoved = true;
            }
            else
            {
                secondButton.transform.position = secondButtonPreviousPosition;
                firstButton.gameObject.SetActive(true);
                secondButtonMoved = false;
            }
        });
    }
}
