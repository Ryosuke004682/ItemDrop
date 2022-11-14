using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.Assertions.Must;

[RequireComponent(typeof(CharacterController))]

public class PlayerMove1 : MonoBehaviour
{
    [Header("PlayerˆÚ“®")]
    public float _speed = 1.0f;//ˆÚ“®—p
    public bool attack = false;

    Vector3 velocity;

    Animator _anim;
    CharacterController _controller;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        _controller = GetComponent<CharacterController>();
        _anim = GetComponent<Animator>();
    }


    private void Update()
    {
        Move();
    }

    protected void Move()
    {
        var horizontal = Input.GetAxis("Horizontal") * _speed;
        var vertical   = Input.GetAxis("Vertical")   * _speed;

        velocity = new(horizontal, 0, vertical);

        if(_controller.isGrounded)
        {
            if(velocity.magnitude > 0.1f)
            {
                _anim.SetFloat("MoveSpeed", velocity.magnitude);
                transform.LookAt(transform.position + velocity);

            }
            else
            {
                _anim.SetFloat("MoveSpeed" , 0);
            }
        }

        _controller.Move(velocity * _speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            attack = true;
            
            if(attack == true)
            {
                _anim.SetBool("Attack" , true);
            }
            
        }
        else if(Input.GetMouseButtonUp(0))
        {
            attack = false;

            if(attack == false)
            {
                _anim.SetBool("Attack" , false);
            }
        }
        
      

    }

}
