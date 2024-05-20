using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Класс, отвечающий за загрузку сцены игры и выход из игры</summary>
public class MenuManager : MonoBehaviour
{
    public Player player;

    /// <summary> Событие нажатия кнопки "Achievements".</summary>
    public void OnAchievementsButtonClick()
    {
        SceneManager.LoadScene("Achievements");
    }

    /// <summary> Событие нажатия кнопки "ExtractRNA".</summary>
    public void OnRNAButtonClick()
    {
        SceneManager.LoadScene("ExtractRNA");
    }

    /// <summary> Событие нажатия кнопки "ExtractDNA".</summary>
    public void OnDNAButtonClick()
    {
        SceneManager.LoadScene("ExtractDNA");
    }

    /// <summary> Событие нажатия кнопки "NutrientMedium".</summary>
    public void OnNutrientButtonClick()
    {
        SceneManager.LoadScene("NutrientMedium");
    }

    /// <summary> Событие нажатия кнопки "PCR".</summary>
    public void OnPCRButtonClick()
    {
        SceneManager.LoadScene("PCR");
    }


    /// <summary> Событие на нажатие кнопки "Выход".</summary>
    public void OnClickExitGame()
    {
        Debug.Log("Exit Game");
        player.SavePlayer();
        //Application.Quit();
    }

    /// <summary> Событие на нажатие кнопки "Выход".</summary>
    public void OnClickBackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}