using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �h���b�v�@�\���L�q���Ă���
///  �m���v�Z���ǉ�
/// </summary>
public class DestroyObj : ItemDrop
{
    private int number;

    private bool drop = false;

    //�I�u�W�F�N�g��|�����Ƃ��Ƀh���b�v������
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
                Debug.Log("�}�O�����I");
            }
            
            else if(drop == true && number >= 30 && number < 60)
            {
                Instantiate(skipjackTuna, this.transform.position, this.transform.rotation);
                Debug.Log("�J�c�I���I");
            }

            else if(drop == true && number >= 60 && number <= 100)
            {
                Instantiate(mackerelPick, this.transform.position, this.transform.rotation);
                Debug.Log("�T���}���I");
            }
        }   
    }
}
