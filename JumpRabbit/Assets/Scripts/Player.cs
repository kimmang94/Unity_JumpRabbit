using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigid = null;
    [SerializeField] protected float jumpPower = 1f;
    public void Init()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _rigid.AddForce(Vector2.one * 0.5f * jumpPower);
        }
    }
}
