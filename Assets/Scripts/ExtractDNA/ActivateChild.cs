using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateChild : MonoBehaviour
{
    public Button button;
    public GameObject parentObject;
    public List<int> childIndex;

    void Start()
    {
        button.onClick.AddListener(() =>
        {
            parentObject.SetActive(true);
            foreach (var child in childIndex)
            {
                parentObject.transform.GetChild(child).gameObject.SetActive(true);
            }
        });
    }
}
