using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ItemDrop")]
public class ItemDrop : MonoBehaviour
{
    //今回のメイン
    //Notion通り、Enumで管理します。
    
    public enum Item
    {
        tuna,        //マグロ
        SkipjackTuna,//カツオ
        MackerelPike //サンマ
    }

    [SerializeField]
    public Item itemType = Item.tuna;

    [SerializeField]
    private string ItemName = "";//アイテムの名前

    [SerializeField]
    private string Item_information = "";//アイテムの情報

    [SerializeField]
    private int number = 0;//何個ドロップしたか


    public Item ItemDP()
    {
        return itemType;
    }

    public string ItemNaming()
    {
        return ItemName;
    }

    public string Information()
    {
        return Item_information;
    }

    public int ItemDropCount()
    {
        return number;
    }
    
}
