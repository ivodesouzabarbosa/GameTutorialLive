using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolGround : PoolObject
{
    public static PoolGround _poolGround;

    protected override void Awake()
    {
        _poolGround = this;
    }
}
