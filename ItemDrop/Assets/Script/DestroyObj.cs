using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ドロップ機能を記述しておく
/// 確率計算も追加
/// </summary>
public class DestroyObj : ItemDrop
{
    private int number;

    public void DropProbability()
    {
        number = Random.Range(0, 100);
    }

    private bool drop = false;

    //オブジェクトを倒したときにドロップさせる
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sword")
        {
            drop = true;
            Destroy(this.gameObject);
            
            if(drop == true)
            {
               if(number <= 40)
                {
                    Instantiate(tuna , this.transform.position , this.transform.rotation);
                }
               else if(number <= 30)
                {
                    Instantiate(skipjackTuna, this.transform.position, this.transform.rotation);
                }
               else
                {
                    Instantiate(mackerelPick, this.transform.position, this.transform.rotation);
                }
                
            }
            

        }
        
    }
}
