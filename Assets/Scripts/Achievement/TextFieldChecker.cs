using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFieldChecker : MonoBehaviour
{
    public ScoreManager scoreManager;
    public TextMeshProUGUI textField1;
    public TextMeshProUGUI textField2;
    public TextMeshProUGUI textField3;
    public Button checkButton;
    private int correctCount = 0;
    [SerializeField] private List<string> correctAnswers;

    void Start()
    {
        checkButton.onClick.AddListener(CheckTextFields);
    }

    void CheckTextFields()
    {
        //string[] correctAnswers = { "answer1", "answer2", "answer3" };
        string[] userAnswers = { textField1.text, textField2.text, textField3.text };

        for (int i = 0; i < userAnswers.Length; i++)
        {
            if (userAnswers[i] == correctAnswers[i])
            {
                correctCount++;
            }
        }
        if (correctCount == 3)
        {
            scoreManager.correctCountPipette = correctCount;
            scoreManager.TotalScoreCount();
        }
        else
        {
            scoreManager.correctCountPipette = 0;
            scoreManager.TotalScoreCount();
        }
    }
}
