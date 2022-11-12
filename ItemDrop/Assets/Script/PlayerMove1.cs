using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class PlayerMove1 : MonoBehaviour
{
    [Header("PlayerˆÚ“®ŠÖ˜A")]
    public float _speed = 0;

    Animator _anim;
    Vector3  velocity;
    CharacterController _controller;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        var horizontal = Input.GetAxisRaw("Horizontal") * _speed;
        var vertical   = Input.GetAxisRaw("Vertical") * _speed;

        if(_controller.isGrounded)
        {
            velocity = new Vector3(horizontal,0,vertical);

            if(velocity.magnitude > 0.1f)
            {
                _anim.SetFloat("MoveSpeed" , velocity.magnitude);
                transform.LookAt(transform.position + velocity);
            }
            else
            {
                _anim.SetFloat("MoveSpeed" , 0f);
            }
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        _controller.Move(velocity * _speed * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
        {
            _anim.SetBool("Attack", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _anim.SetBool("Attack",false);
        }
       

    }

}
