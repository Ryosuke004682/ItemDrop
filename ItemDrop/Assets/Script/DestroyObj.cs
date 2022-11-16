using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    Rigidbody _rb;
    public void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.constraints = RigidbodyConstraints.FreezeRotation;
        _rb.constraints = RigidbodyConstraints.FreezePosition;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sword")
        {
            Destroy(this.gameObject);
        }
    }
}
