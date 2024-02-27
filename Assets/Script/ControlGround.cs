using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Pool;

public class ControlGround : MonoBehaviour
{
    [SerializeField] PoolGround _poolGround;
    [SerializeField] Transform _groundPai;
    [SerializeField] Transform _groundTemp;
    [SerializeField] float _sp;
    int _indexdValue;
    int _cenValue;
    void Start()
    {
        for (int i = 0; i < _poolGround.amountToPool; i++)
        {
            Invoke("GroundInst", .3f);
        }   
    }

    // Update is called once per frame
    void GroundInst()
    {
        GameObject bullet = PoolGround._poolGround.GetPooledObject();
        if (bullet != null)
        {
            _indexdValue++;
            bullet.GetComponent<GroundPref>()._index = _indexdValue;
            if (_indexdValue == _poolGround.amountToPool) {
                bullet.GetComponent<GroundPref>()._cool.SetActive(true);
            }
            bullet.GetComponent<GroundPref>().CenarioSelect(_cenValue);
            if (_cenValue< bullet.GetComponent<GroundPref>()._cenList.Count - 1)
            {
                _cenValue++;
            }
            else {

                _cenValue = 0;

            }
            bullet.transform.localPosition = new Vector3(_groundTemp.localPosition.x + _sp, _groundTemp.position.y, _groundTemp.localPosition.z);
            _groundTemp = bullet.transform;
            bullet.SetActive(true);
        }
    }
   
}
