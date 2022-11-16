using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ドロップ機能を記述しておく
/// </summary>
public class DestroyObj : ItemDrop
{    
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
                Debug.Log("True");
                Instantiate(tuna , this.transform.position , this.transform.rotation);
               
            }
        }
        
    }
}
