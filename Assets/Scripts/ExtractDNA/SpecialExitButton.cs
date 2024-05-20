using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialExitButton : MonoBehaviour
{
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject protocolPanel;

    private bool firstTime = true;
    public void OnClick()
    {
        if (firstTime)
        {
            protocolPanel.SetActive(false);
            firstTime = false;
        }

        else
        {
            protocolPanel.SetActive(false);
            settingsPanel.SetActive(true);
        }
    }
}
