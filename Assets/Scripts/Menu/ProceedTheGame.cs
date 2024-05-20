using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProceedTheGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the "F" key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
