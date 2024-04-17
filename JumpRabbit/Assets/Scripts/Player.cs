using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigid = null;
    [SerializeField] protected float jumpPower = 1f;
    [SerializeField] protected float currentJumpPower = 1f;
    public void Init()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            currentJumpPower += jumpPower;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _rigid.AddForce(Vector2.one * 0.5f * currentJumpPower);
            currentJumpPower = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _rigid.velocity = Vector2.zero;
    }
}
