using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Enemy : MonoBehaviour
{
    public GameObject obj;

    Rigidbody _rb;

    [SerializeField]
    public ItemDrop item;
    

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
        _rb.constraints = RigidbodyConstraints.FreezePosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            Destroy(this.gameObject);

            if (item.ItemNaming() == "É}ÉOÉç")
            {
                Instantiate(obj, transform.position, Quaternion.identity);

                Debug.Log($"{item.ItemNaming()}Ç™óéÇøÇΩÅI");
            }
        }
    }
}
