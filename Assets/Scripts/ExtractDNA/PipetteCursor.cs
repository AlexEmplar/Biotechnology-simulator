using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PipetteCursor : MonoBehaviour
{
    public ScoreManager scoreManager;
    [SerializeField] private Vector2 hotspot;
    [SerializeField] private Texture2D customCursorTexture;

    [SerializeField] private Vector2 rightPrevHotspot;
    [SerializeField] private Texture2D rightPrevTexture;

    [SerializeField] private Vector2 wrongPrevHotspot;
    [SerializeField] private Texture2D wrongPrevTexture;

    public void PipetteOn()
    {
        Cursor.SetCursor(customCursorTexture, hotspot, CursorMode.Auto);
        Cursor.SetCursor(customCursorTexture, hotspot, CursorMode.ForceSoftware);
    }

    public void PipetteOff()
    {
        if (scoreManager.gloves == 1)
        {
            Cursor.SetCursor(rightPrevTexture, rightPrevHotspot, CursorMode.Auto);
            Cursor.SetCursor(rightPrevTexture, rightPrevHotspot, CursorMode.ForceSoftware);
        }
        else
        {
            Cursor.SetCursor(wrongPrevTexture, wrongPrevHotspot, CursorMode.Auto);
            Cursor.SetCursor(wrongPrevTexture, wrongPrevHotspot, CursorMode.ForceSoftware);
        }
    }
}