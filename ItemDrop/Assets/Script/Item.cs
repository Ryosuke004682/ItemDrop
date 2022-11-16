using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   public enum ItemType
   {
        Tuna,
        MackerelPick,
        SkipjackTuna
   }

    public ItemType item;

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Sword")
        {
            Destroy(gameObject);
        }
    }

}
