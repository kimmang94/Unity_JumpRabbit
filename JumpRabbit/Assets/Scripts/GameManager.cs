using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player _player = null;

    private void Awake()
    {
        _player.Init();
    }
}
