using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccg : MonoBehaviour
{
    public GameObject tip;
    public GameObject tip2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane") {

            tip.SetActive(true);

            Invoke("quittip", 3f);

        }
        else if (other.tag == "papper") {

            tip2.SetActive(true);

            Invoke("quittip", 3f);

        }

    }


    private void quittip() {

        tip.SetActive(false);
tip2.SetActive(false);

    }

}
