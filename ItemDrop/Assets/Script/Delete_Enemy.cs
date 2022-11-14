using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
