using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Penspopup : MonoBehaviour
{
    public GameObject penBar;
    public bool isEnabled = false;

    void Start()
    {
        penBar.SetActive(false);
    }

    public void ButtonClicked() {
        isEnabled = !isEnabled;
        penBar.SetActive(isEnabled);
    }
}
