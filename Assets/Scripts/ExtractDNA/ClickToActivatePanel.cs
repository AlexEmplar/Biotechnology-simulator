using UnityEngine;
using UnityEngine.UI;

public class ClickToActivatePanel : MonoBehaviour
{
    public GameObject panelToActivate;
    public float duration = 1.5f;

    public void OnMouseDown()
    {
        panelToActivate.SetActive(true);
        Invoke("DeactivatePanel", duration);
    }

    void DeactivatePanel()
    {
        panelToActivate.SetActive(false);
    }
}
