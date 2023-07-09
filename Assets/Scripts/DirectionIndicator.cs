using UnityEngine;
using UnityEngine.UI;

public class DirectionIndicator : MonoBehaviour
{
    public Button upButton;
    public Button leftButton;
    public Button rightButton;
    public Button downButton;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            upButton.interactable = false;
            leftButton.interactable = true;
            rightButton.interactable = true;
            downButton.interactable = true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            upButton.interactable = true;
            leftButton.interactable = true;
            rightButton.interactable = true;
            downButton.interactable = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            upButton.interactable = true;
            leftButton.interactable = false;
            rightButton.interactable = true;
            downButton.interactable = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            upButton.interactable = true;
            leftButton.interactable = true;
            rightButton.interactable = false;
            downButton.interactable = true;
        }
    }
}
