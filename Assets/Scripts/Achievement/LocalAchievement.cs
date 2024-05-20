using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LocalAchievement : MonoBehaviour
{
    public ScoreManager scoreManager;
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI maxScoreText;
    [SerializeField] private TextMeshProUGUI sentenceText;
    [SerializeField]
    public Button buttonToKeepActive;

    public void OnClick()
    {
        panel.SetActive(true);
        maxScoreText.text = scoreManager.totalScore.ToString() + "/10";
        //sentenceText.text = sentences[Random.Range(0, sentences.Length)];
        if (scoreManager.gloves == 0)
        {
            sentenceText.text += "Forgot to put on gloves";
            sentenceText.text += "\n";
        }
        if (scoreManager.alcohol == 0)
        {
            sentenceText.text += "Forgot to disinfect hands";
            sentenceText.text += "\n";
        }
        if (scoreManager.trashCanOutput == 0)
        {
            sentenceText.text += "Did not change the pipette spouts";
            sentenceText.text += "\n";
        }
        if (scoreManager.correctCountPipette == 0)
        {
            sentenceText.text += "Didn't set up the pipettes correctly";
            sentenceText.text += "\n";
        }

        Button[] buttons = FindObjectsOfType<Button>();

        foreach (Button button in buttons)
        {
            if (button != buttonToKeepActive)
            {
                button.interactable = false;
            }
        }
    }
}