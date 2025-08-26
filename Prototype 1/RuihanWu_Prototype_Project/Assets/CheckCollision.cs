using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    private Whiteboard _whiteboard;
    private Rigidbody _rigidBody;
    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Whiteboard"))
        {
            _rigidBody.isKinematic = true;
            _rigidBody.useGravity = false;

        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Whiteboard"))
        {

            _rigidBody.isKinematic = false;
            _rigidBody.useGravity = true;
        }
    }

}
