using UnityEngine;
using TMPro; // If you're using TextMeshPro for UI

public class KeyboardManager : MonoBehaviour
{
    public TextMeshProUGUI inputField; // Reference to your input field
    private TouchScreenKeyboard keyboard;

    public void OpenKeyboard()
    {
        Debug.Log("OpenKeyboard");
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    private void Update()
    {
        if (keyboard != null && keyboard.status == TouchScreenKeyboard.Status.Done)
        {
            inputField.text = keyboard.text;
            keyboard = null;
        }
    }
}