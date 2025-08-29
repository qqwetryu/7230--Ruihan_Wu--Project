using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPalette : MonoBehaviour
{
    public GameObject colorPalette;
    public bool isEnabled = false;

    void Start()
    {
        colorPalette.SetActive(false);
    }

    public void ButtonClicked() {
        isEnabled = !isEnabled;
        colorPalette.SetActive(isEnabled);
    }
}
