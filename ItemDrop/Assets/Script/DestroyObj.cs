using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �h���b�v�@�\���L�q���Ă���
/// </summary>
public class DestroyObj : ItemDrop
{    
    private bool drop = false;

    //�I�u�W�F�N�g��|�����Ƃ��Ƀh���b�v������
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
