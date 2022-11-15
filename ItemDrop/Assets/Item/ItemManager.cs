using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject obj;

    [SerializeField]
    public ItemDrop item;

    private void Start()
    {
        

    }
    public void Update()
    {
        
    }

    public void ItemDrop()
    {
        if(item.ItemNaming() == "É}ÉOÉç")
        {
            Instantiate(obj , transform.position , Quaternion.identity);
        }
    }
}
