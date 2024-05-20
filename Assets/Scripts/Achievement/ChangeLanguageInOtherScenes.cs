using TMPro;
using UnityEngine;

public class ChangeLanguageInOtherScenes : MonoBehaviour
{
    [SerializeField] private string trueText;
    [SerializeField] private string falseText;
    private TextMeshProUGUI textMeshPro;
    private bool valueFromDontDestroyOnLoad;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        valueFromDontDestroyOnLoad = GameObject.Find("Player").GetComponent<ValueHolder>().Value;
    }

    private void Start()
    {
        if (valueFromDontDestroyOnLoad)
        {
            textMeshPro.text = trueText;
        }
        else
        {
            textMeshPro.text = falseText;
        }
    }
}
