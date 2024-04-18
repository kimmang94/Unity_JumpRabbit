using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormManager : MonoBehaviour
{
    [SerializeField] private Transform spawnPosTrf = null;
    [SerializeField] private PlatForm[] smallPlatformClassArr = null;
    [SerializeField] private PlatForm[] mediumPlatformClassArr = null;
    [SerializeField] private PlatForm[] largePlatformClassArr = null;

    private int platformNum;
    [SerializeField] private Data[] dataArr = null;
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
        Vector2 _pos = spawnPosTrf.position;

        for (int i = 0; i < 15; i++)
        {
            int _platformID = -1;

            foreach (Data _data in dataArr)
            {
                if (_data.TryGetPlatformID(platformNum, out _platformID) == true)
                {
                    break;
                }
            }

            PlatForm[] _platformClassArr = platformsDic[_platformID];


            int _randID = Random.Range(0, _platformClassArr.Length);
            PlatForm _randPlatformClass = _platformClassArr[_randID];

            PlatForm _platformClass = GameObject.Instantiate<PlatForm>(_randPlatformClass);
            _platformClass.Activate(_pos);

            _pos += Vector2.right * 6f;

            platformNum++;
        }

    }

    [System.Serializable]
    public class Data
    {
        [SerializeField] private int conditionNum;
        [SerializeField] private float[] percentArr = new float[3];
        public bool TryGetPlatformID(int _platformNum, out int platformID)
        {
            if (conditionNum <= _platformNum)
            {
                float _value = Random.value;

                for (int i = 0; i < percentArr.Length; i++)
                {
                    if (_value < percentArr[i])
                    {
                        platformID = i;
                        return true;
                    }
                    else
                    {
                        _value -= percentArr[i];
                    }
                }

                platformID = 0;

                return true;
            }
            else
            {
                platformID = -1;
                return false;
            }
        }
    }
}
