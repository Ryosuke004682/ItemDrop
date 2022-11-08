using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class PlayerMove1 : MonoBehaviour
{
    [Tooltip("移動スピード")]
    [SerializeField] public float _speed = 2.5f;


    CharacterController _controller;
    Transform _transform;
    Vector3 _movePosition;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        _controller = GetComponent<CharacterController>();

        _transform = transform;
    }

    private void FixedUpdate()
    {
        _movePosition.x = Input.GetAxis("Horizontal") * _speed;
        _movePosition.z = Input.GetAxis("Vertical") * _speed;

        _transform.LookAt(_transform.position + new Vector3
                        (_movePosition.x, 0, _movePosition.z));

        _controller.Move(_movePosition * Time.deltaTime);
    }

   
}
