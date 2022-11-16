using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//だいたい同じ確率でドロップさせる

public class ItemDrop : MonoBehaviour
{
    public Item tuna;       　//マグロ
    public Item mackerelPick; //サンマ
    public Item skipjackTuna; //カツオ

    void Drop()
    {
        float random = Random.Range(0 , 1f);

        if(random <= 0.33)
        {
            Instantiate(tuna , transform.position, Quaternion.identity);
        }
        else if(random <= 0.33)
        {
            Instantiate(mackerelPick, transform.position, Quaternion.identity);
        }
        else if(random <= 0.33)
        {
            Instantiate(skipjackTuna, transform.position, Quaternion.identity);
        }
    }
}
