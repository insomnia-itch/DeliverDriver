using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroySpeed = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(0, 255, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroySpeed);
        } else if (other.tag == "Customer" && hasPackage) {
            Debug.Log("package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
        Debug.Log("trace on, trigger off");
    }
}
