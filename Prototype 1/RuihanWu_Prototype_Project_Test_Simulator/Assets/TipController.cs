using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipController : MonoBehaviour
{
    public Animator tipAnimator;
    // Start is called before the first frame update
    void OnEnable()
    {
        tipAnimator.SetTrigger("Show");
        StartCoroutine(hideUI());
    }

    private IEnumerator hideUI()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("hide ui");
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
