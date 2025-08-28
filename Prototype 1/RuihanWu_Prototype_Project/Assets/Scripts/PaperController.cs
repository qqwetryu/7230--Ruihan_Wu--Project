using UnityEngine;
using TMPro;

public class PaperController : MonoBehaviour
{
    [Header("纸张设置")]
    public Color normalColor = Color.white;
    public Color clickedColor = Color.cyan;
    
    [Header("键盘设置")]
    public GameObject keyboardPrefab;
    public Vector3 keyboardOffset = new Vector3(0, 0.5f, -0.8f);
    
    private GameObject currentKeyboard;
    private TextMeshPro textDisplay;
    private string currentText = "";
    private bool keyboardActive = false;
    
    void Start()
    {
        // 设置纸张外观
        GetComponent<Renderer>().material.color = normalColor;
        
        // 创建文本显示
        CreateTextDisplay();
        
        Debug.Log("纸张初始化完成");
    }
    
    void CreateTextDisplay()
    {
        GameObject textObj = new GameObject("TextDisplay");
        textObj.transform.SetParent(transform);
        textObj.transform.localPosition = new Vector3(0, 0.6f, 0);
        textObj.transform.localRotation = Quaternion.Euler(90, 0, 0);
        
        textDisplay = textObj.AddComponent<TextMeshPro>();
        textDisplay.text = currentText;
        textDisplay.fontSize = 1;
        textDisplay.color = Color.black;
        textDisplay.alignment = TextAlignmentOptions.TopLeft;
        textDisplay.rectTransform.sizeDelta = new Vector2(1.8f, 1.3f);
    }
    
    void OnMouseDown()
    {
        Debug.Log("纸张被点击");
        
        // 视觉反馈
        GetComponent<Renderer>().material.color = clickedColor;
        Invoke("RestoreColor", 0.3f);
        
        // 切换键盘
        ToggleKeyboard();
    }
    
    void RestoreColor()
    {
        GetComponent<Renderer>().material.color = normalColor;
    }
    
    void ToggleKeyboard()
    {
        if (!keyboardActive)
        {
            ShowKeyboard();
        }
        else
        {
            HideKeyboard();
        }
        keyboardActive = !keyboardActive;
    }
    
    void ShowKeyboard()
    {
        if (currentKeyboard == null)
        {
            currentKeyboard = new GameObject("VirtualKeyboard");
            currentKeyboard.transform.position = transform.position + keyboardOffset;
            
            // 创建键盘面板
            GameObject panel = GameObject.CreatePrimitive(PrimitiveType.Cube);
            panel.transform.SetParent(currentKeyboard.transform);
            panel.transform.localPosition = Vector3.zero;
            panel.transform.localScale = new Vector3(3, 0.1f, 1);
            panel.GetComponent<Renderer>().material.color = Color.gray;
            panel.name = "KeyboardPanel";
            
            // 创建按键
            CreateKeys();
        }
        currentKeyboard.SetActive(true);
        Debug.Log("键盘已显示");
    }
    
    void HideKeyboard()
    {
        if (currentKeyboard != null)
        {
            currentKeyboard.SetActive(false);
        }
        Debug.Log("键盘已隐藏");
    }
    
    void CreateKeys()
    {
        string[] keys = {"A", "B", "C", "D", "E", "Space", "Delete"};
        
        for (int i = 0; i < keys.Length; i++)
        {
            GameObject key = GameObject.CreatePrimitive(PrimitiveType.Cube);
            key.transform.SetParent(currentKeyboard.transform);
            
            float x = (i - 3) * 0.4f;
            key.transform.localPosition = new Vector3(x, 0.1f, 0);
            key.transform.localScale = new Vector3(0.3f, 0.1f, 0.3f);
            key.name = "Key_" + keys[i];
            
            // 添加按键脚本
            VirtualKey keyScript = key.AddComponent<VirtualKey>();
            keyScript.keyValue = keys[i];
            keyScript.paperController = this;
            
            // 添加文字标签
            GameObject label = new GameObject("Label");
            label.transform.SetParent(key.transform);
            label.transform.localPosition = new Vector3(0, 0.11f, 0);
            label.transform.localRotation = Quaternion.Euler(90, 0, 0);
            
            TextMeshPro labelText = label.AddComponent<TextMeshPro>();
            labelText.text = keys[i];
            labelText.fontSize = 0.5f;
            labelText.color = Color.black;
            labelText.alignment = TextAlignmentOptions.Center;
        }
    }
    
    public void OnKeyPressed(string key)
    {
        if (key == "Space")
        {
            currentText += " ";
        }
        else if (key == "Delete" && currentText.Length > 0)
        {
            currentText = currentText.Substring(0, currentText.Length - 1);
        }
        else if (key != "Delete")
        {
            currentText += key;
        }
        
        UpdateText();
        Debug.Log("按键: " + key + ", 当前文本: " + currentText);
    }
    
    void UpdateText()
    {
        if (textDisplay != null)
        {
            textDisplay.text = currentText;
        }
    }
}