using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroySpeed = 0.5f;
    void OnCollisionEnter2D(Collision2D other)
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("package picked up");
            Destroy(other.gameObject, destroySpeed);
            hasPackage = true;
        } else if (other.tag == "Customer" && hasPackage) {
            Debug.Log("package delivered");
            hasPackage = false;
        }
        Debug.Log("trace on, trigger off");
    }
}
