using UnityEngine;
using UnityEngine.UI;

public class SwitchPageButton : MonoBehaviour
{
    public GameObject book; // The parent GameObject that contains all the pages of the book
    private int currentPageIndex; // The index of the currently active page

    private void Start()
    {
        // Deactivate all the pages of the book at the beginning
        foreach (Transform child in book.transform)
        {
            child.gameObject.SetActive(false);
        }

        // Activate the first page of the book
        book.transform.GetChild(0).gameObject.SetActive(true);
        currentPageIndex = 0;
    }

    public void NextPageButtonClick()
    {
        // If there is a next page, deactivate the current page and activate the next page
        if (currentPageIndex < book.transform.childCount - 1)
        {
            book.transform.GetChild(currentPageIndex).gameObject.SetActive(false);
            book.transform.GetChild(currentPageIndex + 1).gameObject.SetActive(true);
            currentPageIndex++;
        }
        // If there are no more pages, do nothing
        else
        {
            Debug.Log("No more pages to turn");
        }
    }

    public void PreviousPageButtonClick()
    {
        // If there is a next page, deactivate the current page and activate the next page
        if (currentPageIndex > 0)
        {
            book.transform.GetChild(currentPageIndex).gameObject.SetActive(false);
            book.transform.GetChild(currentPageIndex - 1).gameObject.SetActive(true);
            currentPageIndex--;
        }
        // If there are no more pages, do nothing
        else
        {
            Debug.Log("No more pages to turn");
        }
    }
}
