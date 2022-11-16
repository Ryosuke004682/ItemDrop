using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ドロップするアイテムについて書いてく
/// </summary>
public class ItemDrop : MonoBehaviour
{
    //実験用の簡易的なドロップ機能なので、
    //ここにRigidbodyを追加しときます。
    //（本当は、Enemyのステータスを管理してるところに書こうね）

    Rigidbody _rb;
    public void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.freezeRotation = true;
        _rb.constraints = RigidbodyConstraints.FreezePosition;
    }


    //ドロップさせるアイテムを書いておく
    public Item tuna;       　//マグロ
}
