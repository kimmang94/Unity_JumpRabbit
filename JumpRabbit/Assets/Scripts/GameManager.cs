using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player _player = null;
    [SerializeField] private PlatFormManager _platFormManager = null;

    private void Awake()
    {
        _player.Init();
        _platFormManager.Init();
    }

    private void Start()
    {
        _platFormManager.Activate();
    }
}
