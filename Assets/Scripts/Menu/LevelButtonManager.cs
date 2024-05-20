using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButtonsManager : MonoBehaviour
{
    public Button[] levelButtons;
    public int[] maxScores;
    public int currentLevelIndex = 0;
    public GameObject reminderPanel;
    [SerializeField] private string substitudeText;
    [SerializeField] private string originalText;
    [SerializeField] private List<string> sceneNames;
    [SerializeField] private Button loadButton;

    public Player player;


    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Start()
    {
        //UpdateButtonTexts();
        loadButton.onClick.AddListener(() =>
        {
            UpdateOpenLevel();
        });
    }

    void UpdateButtonTexts()
    {
        for (int i = 1; i < levelButtons.Length; i++)
        {
            levelButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = substitudeText;
        }
    }

    public void TryToEnterALevel(Button button)
    {
        if (button.GetComponentInChildren<TextMeshProUGUI>().text == substitudeText)
        {
            reminderPanel.SetActive(true);
        }
        else
        {
            for (int i = 0; i < levelButtons.Length; i++)
            {
                if (button.name == levelButtons[i].name)
                {
                    SceneManager.LoadScene(sceneNames[i]);
                    print(sceneNames[i]);
                    break;
                }
            }
        }
    }

    public void OnLevelComplete(int score)
    {
        if (score >= maxScores[currentLevelIndex])
        {
            currentLevelIndex++;
            if (currentLevelIndex < levelButtons.Length)
            {
                levelButtons[currentLevelIndex].interactable = true;
                UpdateButtonTexts();
            }
        }
    }

    public void UpdateOpenLevel()
    {
        for (int i = 1; i < levelButtons.Length; i++)
        {
            if (player.levelScore[i - 1] < maxScores[i])
            {
                levelButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = substitudeText;
            }
            else
            {
                levelButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = originalText;
            }
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateOpenLevel();
    }
}

