using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Item" , menuName = "CreateItem")]
public class ItemDrop : MonoBehaviour
{
   public enum Item
    {
        Tuna,
        SkipjackTuna,
        MackerelPick
    }

    [SerializeField]
    public Item itemType = Item.Tuna;

    [SerializeField]
    private string itemName = "";

    [SerializeField]
    private string information = "";

    [SerializeField]
    private int amount = 0;

    public Item GetItemType()
    {
        return itemType;
    }

    public string ItemNaming()
    {
        return itemName;
    }

    public string Information()
    {
        return information;
    }

    public int GetAmount()
    {
        return amount;
    }

}
