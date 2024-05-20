using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour
{
    public GameObject pauseMenuObject;
    private bool isPaused;
    private Button[] otherButtons;
    //public List<Button> MenuButtons;

    void Start()
    {
        isPaused = false;
        pauseMenuObject.SetActive(false);

        otherButtons = FindObjectsOfType<Button>();

        foreach (Button button in otherButtons)
        {
            button.interactable = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                if (pauseMenuObject.activeSelf)
                {
                    Resume();
                }
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuObject.SetActive(false);
        Time.timeScale = 1f;

        foreach (Button button in otherButtons)
        {
            button.interactable = true;
        }

        isPaused = false;
    }

    void Pause()
    {
        pauseMenuObject.SetActive(true);
        Time.timeScale = 0f;

        otherButtons = FindObjectsOfType<Button>();

        foreach (Button button in otherButtons)
        {
            button.interactable = false;
        }

        isPaused = true;
    }
}
