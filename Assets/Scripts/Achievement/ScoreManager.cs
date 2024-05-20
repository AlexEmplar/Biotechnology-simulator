using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int maxTrashCanCount;
    public int gloves = 0;
    public int alcohol = 0;

    public int totalScore = 0;

    private int scoreForDesinfection = 0;

    private int trashCan = 0;

    public int correctCountPipette = 0;

    public bool wrongTouch = false;

    public int trashCanOutput = 0;
    public void infection()
    {
        if (gloves != 1 || alcohol != 1)
        {
            wrongTouch = true;
            print("poison");
        }
        TotalScoreCount();
    }

    public void DesinfectionGloves()
    {
        if (!wrongTouch)
        {
            gloves = 1;
            print("good");
        }

        else
        {
            scoreForDesinfection = -2;
            print("death");
        }
        TotalScoreCount();
    }

    public void DesinfectionAlcohol()
    {
        if (!wrongTouch)
        {
            alcohol = 1;
            print("good");
        }
        else
        {
            scoreForDesinfection = -2;
            print("death");
        }
        TotalScoreCount();
    }

    public void trashCanCount()
    {
        trashCan += 1;
        TotalScoreCount();
    }

    public void TotalScoreCount()
    {
        trashCanOutput = (int)(Mathf.Round(trashCan / maxTrashCanCount));
        totalScore = gloves + alcohol + scoreForDesinfection + trashCanOutput + correctCountPipette;
        if (totalScore < 0)
        {
            totalScore = 0;
        }
    }
}
