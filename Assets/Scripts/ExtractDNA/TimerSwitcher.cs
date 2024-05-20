using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerSwitcher : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public TextMeshProUGUI textDisplay;
    private string[] sentences = {
        "30 sec",
        "1 min",
        "2 min",
        "5 min",
        "10 min"
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
