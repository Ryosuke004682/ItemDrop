using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class CamouflageWind : MonoBehaviour
{
    public float _speed   = 5.0f;
    public float maxAngle = 30.0f;

    float startTime;
    Quaternion rotation;

    private void Start()
    {
        startTime = Time.time;
        rotation = transform.rotation;
    }

    public void FixedUpdate()
    {
        transform.rotation = rotation * Quaternion.Euler
            (Mathf.Sin((Time.time - startTime) * _speed) * maxAngle , 0.0f , 0.0f);
    }

}
