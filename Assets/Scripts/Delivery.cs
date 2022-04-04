using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package") 
        {
            Debug.Log("package picked up");
        } else if (other.tag == "Customer") {
            Debug.Log("package delivered");
        }
        Debug.Log("trace on, trigger off");
    }
}
