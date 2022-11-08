using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Tooltip("移動スピード")]
    public float _moveSpeed = 6.0f;
    public float _rotateSpeed = 0.1f;

    //回転ベクトル
    float _rotateVertical;


    Transform _cameraTransform;
    CharacterController _controller;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal , 0.0f , vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x , direction.z) * 
                                Mathf.Rad2Deg + _cameraTransform.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y ,
                                    targetAngle , ref _rotateVertical,_rotateSpeed);


            transform.rotation = Quaternion.Euler(0.0f,targetAngle,0.0f);

            Vector3 moveDirection = Quaternion.Euler(0.0f,targetAngle,0.0f) * Vector3.forward;


            _controller.Move(moveDirection * _moveSpeed * Time.deltaTime);


        }

    }

}
