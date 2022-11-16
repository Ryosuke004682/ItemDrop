using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.constraints = RigidbodyConstraints.FreezePosition;
        _rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    public enum ItemType
   {
        Tuna,
        MackerelPick,
        SkipjackTuna
   }

    public ItemType item;
}
