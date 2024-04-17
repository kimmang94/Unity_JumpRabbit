using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatForm : MonoBehaviour
{
    [SerializeField] private BoxCollider2D col = null;
    [SerializeField] private SpriteRenderer srdr = null;

    public void Activate(Vector2 pos)
    {
        transform.position = pos;
    }
}
