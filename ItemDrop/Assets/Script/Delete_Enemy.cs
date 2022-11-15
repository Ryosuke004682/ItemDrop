using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Enemy : MonoBehaviour
{
    public GameObject obj;

    [SerializeField]
    public ItemDrop item;
    

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sword")
        {
            Destroy(gameObject);
        }

        if(item.ItemNaming() == "É}ÉOÉç")
        {
            Instantiate(obj,transform.position , Quaternion.identity);

            Debug.Log($"{item.ItemNaming()}Ç™óéÇøÇΩÅI");
        }
    }
}
