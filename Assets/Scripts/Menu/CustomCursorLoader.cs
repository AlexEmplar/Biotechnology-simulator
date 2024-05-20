using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCursorOnSceneLoad : MonoBehaviour
{
    [SerializeField] private Vector2 hotspot;
    [SerializeField] private Texture2D customCursorTexture;

    public CursorData cursorData;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnApplicationQuit()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        List<string> customCursorScenes = new List<string> { "ExtractDNA", "PCR", "NutrientMedium" };
        if (customCursorScenes.Contains(scene.name))
        {
            Cursor.SetCursor(customCursorTexture, hotspot, CursorMode.Auto);
            Cursor.SetCursor(customCursorTexture, hotspot, CursorMode.ForceSoftware);
            cursorData.UpdateCursorData(hotspot, customCursorTexture);
            print(cursorData.hotspot);
        }
        else
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }
}

