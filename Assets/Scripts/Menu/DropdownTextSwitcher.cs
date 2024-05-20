using TMPro;
using UnityEngine;

public class DropdownTextSwitcher : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private TextMeshProUGUI textToSwitch;
    [SerializeField] private string option1Text;
    [SerializeField] private string option2Text;

    private const string PREF_KEY = "DropdownChoice";

    private void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);

        // Load the saved choice
        int savedChoice = PlayerPrefs.GetInt(PREF_KEY, 0); // 0 is the default value if no choice is saved
        dropdown.value = savedChoice;
        textToSwitch.text = savedChoice == 0 ? option1Text : option2Text;
    }

    private void OnDropdownValueChanged(int dropdownIndex)
    {
        textToSwitch.text = dropdownIndex == 0 ? option1Text : option2Text;

        // Save the choice
        PlayerPrefs.SetInt(PREF_KEY, dropdownIndex);

    }
}
