using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSwitcher : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public TextMeshProUGUI textDisplay;
    private string[] sentences = {
        "8 g",
        "9 g",
        "10 g"
    };
    private int sentenceIndex = 0;

    void Start()
    {
        textDisplay.text = sentences[sentenceIndex];

        button1.onClick.AddListener(() =>
        {
            ForwardSwitchSentence();
        });

        button2.onClick.AddListener(() =>
        {
            BackSwitchSentence();
        });
    }

    public void ForwardSwitchSentence()
    {
        if (sentenceIndex < sentences.Length)
        {
            sentenceIndex++;
        }

        textDisplay.text = sentences[sentenceIndex];
    }

    public void BackSwitchSentence()
    {
        if (sentenceIndex > 0)
        {
            sentenceIndex--;
        }

        textDisplay.text = sentences[sentenceIndex];
    }
}
