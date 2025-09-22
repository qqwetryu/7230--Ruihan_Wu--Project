using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccg1 : MonoBehaviour
{
    public GameObject ob1;
    public GameObject obj2;
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

            if(ob1.gameObject.activeSelf==true){

                ob1.SetActive(false);
            }
            else{

                ob1.SetActive(true);


            }

          

        }
        else if (other.tag == "papper") {

                        if(obj2.gameObject.activeSelf==true){

                obj2.SetActive(false);
            }
            else{

                obj2.SetActive(true);


            }

        }

    }




    

}
