using UnityEngine;

public class VirtualKey : MonoBehaviour
{
    public string keyValue;
    public PaperController paperController;
    
    private Color normalColor = Color.white;
    private Color pressedColor = Color.yellow;
    
    void Start()
    {
        GetComponent<Renderer>().material.color = normalColor;
    }
    
    void OnMouseDown()
    {
        // 视觉反馈
        GetComponent<Renderer>().material.color = pressedColor;
        Invoke("RestoreColor", 0.2f);
        
        // 通知纸张控制器
        if (paperController != null)
        {
            paperController.OnKeyPressed(keyValue);
        }
        
        Debug.Log("按键被按下: " + keyValue);
    }
    
    void RestoreColor()
    {
        GetComponent<Renderer>().material.color = normalColor;
    }
}