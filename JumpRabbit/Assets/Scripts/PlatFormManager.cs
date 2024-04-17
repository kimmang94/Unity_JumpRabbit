using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormManager : MonoBehaviour
{
    [SerializeField] private Transform spawnPosTrf = null;
    [SerializeField] private PlatForm[] smallPlatformClassArr = null;
    [SerializeField] private PlatForm[] mediumPlatformClassArr = null;
    [SerializeField] private PlatForm[] largePlatformClassArr = null;

    private Dictionary<int, PlatForm[]> platformsDic; 
    public void Init()
    {
        platformsDic = new Dictionary<int, PlatForm[]>();

        platformsDic.Add(0, smallPlatformClassArr);
        platformsDic.Add(1, mediumPlatformClassArr);
        platformsDic.Add(2, largePlatformClassArr);
    }

    public void Activate()
    {
        PlatForm[] platFormClassArr = platformsDic[2];

        var randID =  Random.RandomRange(0, platFormClassArr.Length);
        PlatForm randPlatForm =  platFormClassArr[randID];

        PlatForm platformClass =  GameObject.Instantiate<PlatForm>(randPlatForm);
        Vector2 _pos = spawnPosTrf.position;
        platformClass.Activate(_pos);
    }
}
