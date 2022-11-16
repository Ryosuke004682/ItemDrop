using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sword")
        {
            Destroy(this.gameObject);
        }
    }
}
