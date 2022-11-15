using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    private ItemManager item;

    protected void Start()
    {
        item = GetComponent<ItemManager>();
    }

    protected void Death()
    {
        item.ItemDrop();
    }
}
