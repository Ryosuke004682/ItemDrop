using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ItemDrop")]
public class ItemDrop : MonoBehaviour
{
    //����̃��C��
    //Notion�ʂ�AEnum�ŊǗ����܂��B
    
    public enum Item
    {
        tuna,        //�}�O��
        SkipjackTuna,//�J�c�I
        MackerelPike //�T���}
    }

    [SerializeField]
    public Item itemType = Item.tuna;

    [SerializeField]
    private string ItemName = "";//�A�C�e���̖��O

    [SerializeField]
    private string Item_information = "";//�A�C�e���̏��

    [SerializeField]
    private int number = 0;//���h���b�v������


    public Item ItemDP()
    {
        return itemType;
    }

    public string ItemNaming()
    {
        return ItemName;
    }

    public string Information()
    {
        return Item_information;
    }

    public int ItemDropCount()
    {
        return number;
    }
    
}
