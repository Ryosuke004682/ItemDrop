using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �h���b�v����A�C�e���ɂ��ď����Ă�
/// </summary>
public class ItemDrop : MonoBehaviour
{
    //�����p�̊ȈՓI�ȃh���b�v�@�\�Ȃ̂ŁA
    //������Rigidbody��ǉ����Ƃ��܂��B
    //�i�{���́AEnemy�̃X�e�[�^�X���Ǘ����Ă�Ƃ���ɏ������ˁj

    Rigidbody _rb;
    public void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.freezeRotation = true;
        _rb.constraints = RigidbodyConstraints.FreezePosition;
    }


    //�h���b�v������A�C�e���������Ă���
    public Item tuna;       �@//�}�O��
}
