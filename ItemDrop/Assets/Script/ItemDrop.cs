using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������������m���Ńh���b�v������

public class ItemDrop : MonoBehaviour
{
    public Item tuna;       �@//�}�O��
    public Item mackerelPick; //�T���}
    public Item skipjackTuna; //�J�c�I

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
