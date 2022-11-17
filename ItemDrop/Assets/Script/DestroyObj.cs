using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// ドロップ機能を記述しておく
///  確率計算も追加
/// </summary>
public class DestroyObj : ItemDrop
{
    private int number;

    private bool drop = false;

    //オブジェクトを倒したときにドロップさせる
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sword")
        {
            drop = true;
            Destroy(this.gameObject);


            number = Random.Range(0, 101);

            if (drop == true && number >= 0 && number < 30)
            {
                Instantiate(tuna,this.transform.position , this.transform.rotation);
                Debug.Log("マグロだ！");
            }
            
            else if(drop == true && number >= 30 && number < 60)
            {
                Instantiate(skipjackTuna, this.transform.position, this.transform.rotation);
                Debug.Log("カツオだ！");
            }

            else if(drop == true && number >= 60 && number <= 100)
            {
                Instantiate(mackerelPick, this.transform.position, this.transform.rotation);
                Debug.Log("サンマだ！");
            }
        }   
    }
}
