using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shake : MonoBehaviour
{    
    public void OnClickShake()
    {
        transform.DOShakePosition(0.2f, 5, 50, 360, false, false).SetLoops(5, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
