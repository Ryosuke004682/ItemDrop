using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            if(this.gameObject.tag == "tuna")
            {
                Debug.Log("�}�O�����l���I");
            }
            if(this.gameObject.tag == "skipjackTuna")
            {
                Debug.Log("�J�c�I���l���I");
            }
            if(this.gameObject.tag == "mackerelPike")
            {
                Debug.Log("�T���}���l���I");
            }
        }
    }
}
