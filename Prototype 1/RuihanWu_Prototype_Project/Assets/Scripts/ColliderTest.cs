using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    void Start()
    {
        // 检查组件
        Debug.Log("=== 组件检查 ===");
        Debug.Log("Transform: " + (GetComponent<Transform>() != null ? "✅" : "❌"));
        Debug.Log("MeshFilter: " + (GetComponent<MeshFilter>() != null ? "✅" : "❌"));
        Debug.Log("MeshRenderer: " + (GetComponent<MeshRenderer>() != null ? "✅" : "❌"));
        Debug.Log("MeshCollider: " + (GetComponent<MeshCollider>() != null ? "✅" : "❌"));
        Debug.Log("BoxCollider: " + (GetComponent<BoxCollider>() != null ? "✅" : "❌"));
        
        // 检查对象状态
        Debug.Log("=== 对象状态 ===");
        Debug.Log("GameObject active: " + gameObject.activeInHierarchy);
        Debug.Log("Position: " + transform.position);
        Debug.Log("Scale: " + transform.localScale);
        
        // 自动添加碰撞器（如果没有）
        if (GetComponent<Collider>() == null)
        {
            Debug.Log("⚠️ 没有找到碰撞器，自动添加BoxCollider");
            gameObject.AddComponent<BoxCollider>();
        }
    }
    
    // 鼠标进入检测
    void OnMouseEnter()
    {
        Debug.Log("🖱️ 鼠标进入了纸张区域！");
        GetComponent<Renderer>().material.color = Color.cyan;
    }
    
    // 鼠标离开检测
    void OnMouseExit()
    {
        Debug.Log("🖱️ 鼠标离开了纸张区域！");
        GetComponent<Renderer>().material.color = Color.white;
    }
    
    // 鼠标点击检测
    void OnMouseDown()
    {
        Debug.Log("🎉 鼠标点击成功！时间: " + System.DateTime.Now.ToString("HH:mm:ss"));
        
        // 创建明显的视觉反馈
        GetComponent<Renderer>().material.color = Color.red;
        
        // 创建测试立方体
        GameObject testCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        testCube.name = "ClickTest_Success";
        testCube.transform.position = transform.position + Vector3.up * 0.5f;
        testCube.transform.localScale = Vector3.one * 0.3f;
        testCube.GetComponent<Renderer>().material.color = Color.green;
        
        Debug.Log("✅ 绿色立方体已创建在位置: " + testCube.transform.position);
        
        // 5秒后销毁立方体并恢复颜色
        Destroy(testCube, 5f);
        Invoke("RestoreColor", 2f);
    }
    
    void RestoreColor()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    
    // 每秒检查一次鼠标位置（调试用）
    void Update()
    {
        if (Time.frameCount % 60 == 0) // 每秒一次
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    Debug.Log("🎯 鼠标正对准纸张！");
                }
            }
        }
        
        // 空格键备用测试
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("🔲 空格键测试 - 强制触发点击效果");
            OnMouseDown();
        }
    }
}