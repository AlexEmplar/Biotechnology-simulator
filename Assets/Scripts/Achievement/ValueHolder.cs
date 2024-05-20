using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ValueHolder : MonoBehaviour
{
    [SerializeField] private string dropdownName;
    public static ValueHolder Instance { get; private set; }

    private GameObject dropdown;
    private TMP_Dropdown dropdownMeta;
    public bool Value = true;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;

        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDropdownValueChanged(int dropdownIndex)
    {
        if (dropdownIndex == 0)
        {
            Value = true;
        }
        else
        {
            Value = false;
        }
        print(Value);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject[] objectsWithTag = GameObject.FindObjectsOfType<GameObject>(true);

        foreach (GameObject obj in objectsWithTag)
        {
            if (obj.CompareTag("LanguageMode"))
            {
                dropdown = obj;
                break;
            }
        }

        if (dropdown != null)
        {
            dropdownMeta = dropdown.GetComponent<TMP_Dropdown>();
            dropdownMeta.onValueChanged.AddListener(OnDropdownValueChanged);
        }
    }
}
