using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StickyNote : MonoBehaviour
{
    public Button editButton; // 连接到编辑按钮
    public InputField inputField; // 连接到输入框
    public TextMeshProUGUI displayText; // 连接到显示文本

    private bool isBeingHeld = false;

    void Start()
    {
        editButton.onClick.AddListener(OpenInputField);
        inputField.onEndEdit.AddListener(UpdateText);
    }
    

    public void OpenInputField()
    {
        inputField.gameObject.SetActive(true);
        inputField.ActivateInputField(); // 激活输入框
    }

    public void UpdateText(string newText)
    {
        displayText.text = newText; // 更新显示的文本
        inputField.gameObject.SetActive(false); // 隐藏输入框
    }

    public void PickUp()
    {
        isBeingHeld = true;
    }

    public void Drop()
    {
        isBeingHeld = false;
    }
}