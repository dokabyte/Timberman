using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class TrunkBase : MonoBehaviour
{
    [SerializeField] private float moveOffset;

    private void OnEnable()
    {
        TrunkPool.OnTrunkHitted += TrunkFall;
    }

    private void TrunkFall()
    {
        transform.position = new Vector2(0, transform.position.y - moveOffset);
    }

    public void TrunkHitted()
    {
        TrunkPool.OnTrunkHitted -= TrunkFall;
        TrunkPool.OnTrunkHitted?.Invoke();
    }
    
    
}
