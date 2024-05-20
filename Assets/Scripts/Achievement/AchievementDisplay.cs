using UnityEngine;
using TMPro;

public class AchievementDisplay : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject panelRestrict;
    [SerializeField] private TextMeshProUGUI maxScoreText;
    [SerializeField] private TextMeshProUGUI sentenceText;
    [SerializeField] private int orderOfAchievement;
    public LevelButtonsManager levelButtonManager;
    //[SerializeField] private int maxScore = 10;
    [SerializeField]
    private string[] sentences = {
        "You did great!",
        "Good job!",
        "Keep it up!",
        "Nice work!",
        "Excellent!"
    };

    public void OnClick(Player player)
    {
        if (player.levelScore[orderOfAchievement] >= levelButtonManager.maxScores[orderOfAchievement])
        {
            if (player.levelScore[orderOfAchievement] == 0)
            {
                panelRestrict.SetActive(true);
            }
            else
            {
                panel.SetActive(true);
                maxScoreText.text = player.levelScore[orderOfAchievement].ToString() + "/10";
                sentenceText.text = sentences[Random.Range(0, sentences.Length)];
            }
        }
        else
        {
            panelRestrict.SetActive(true); 
        }
    }
}
