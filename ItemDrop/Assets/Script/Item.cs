using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// アイテムの種類を列挙しておく
/// </summary>
public class Item : MonoBehaviour
{
    public enum ItemType
   {
        Tuna,　　　　　//マグロ
        MackerelPick,　//サンマ
        SkipjackTuna　 //カツオ
   }
    public ItemType item;

}
