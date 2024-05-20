using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int[] levelScore;

    public PlayerData (Player player) 
    {
        levelScore = new int[player.levelScore.Length];
        for (int i = 0; i < levelScore.Length; i++)
        {
            levelScore[i] = player.levelScore[i];
        }
    }
}

