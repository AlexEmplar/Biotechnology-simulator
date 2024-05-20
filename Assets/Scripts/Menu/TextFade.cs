using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textElement;
    [SerializeField] private float fadeDuration = 1f;
    [SerializeField] private float waitDuration = 3f;

    private float timer;
    private bool isFadingIn;

    private void Start()
    {
        // Set the initial transparency of the text element
        textElement.color = new Color(textElement.color.r, textElement.color.g, textElement.color.b, 0.5f);

        // Start the first fade-in cycle
        isFadingIn = true;
        timer = 0;
    }

    private void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if the timer has exceeded the current phase duration
        if (isFadingIn)
        {
            // Fade-in phase
            if (timer > fadeDuration)
            {
                // Switch to the wait phase
                isFadingIn = false;
                timer = 0;
            }
            else
            {
                // Update the transparency of the text element
                float alpha = Mathf.Lerp(0, 1, timer / fadeDuration);
                textElement.color = new Color(textElement.color.r, textElement.color.g, textElement.color.b, (float)0.5*alpha);
            }
        }
        else
        {
            // Fade-out or wait phase
            if (timer > waitDuration + fadeDuration)
            {
                // Switch to the fade-in phase
                isFadingIn = true;
                timer = 0;
            }
            else if (timer > waitDuration)
            {
                // Fade-out phase
                float alpha = Mathf.Lerp(1, 0, (timer - waitDuration) / fadeDuration);
                textElement.color = new Color(textElement.color.r, textElement.color.g, textElement.color.b, (float)0.5 * alpha);
            }
        }
    }
}
