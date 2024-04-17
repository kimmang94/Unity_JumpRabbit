using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigid = null;
    [SerializeField] private float jumpPower = 1f;
    [SerializeField] private float currentJumpPower = 1f;
    [SerializeField] private Animator _anim = null;
    public void Init()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _anim.SetInteger("StateID", 1);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            currentJumpPower += jumpPower;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _rigid.AddForce(Vector2.one * 0.5f * currentJumpPower);
            currentJumpPower = 0f;

            _anim.SetInteger("StateID", 2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _rigid.velocity = Vector2.zero;
        _anim.SetInteger("StateID", 0);
    }
}
