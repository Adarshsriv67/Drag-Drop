using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Blink : MonoBehaviour
{
    public Image blink;
    //public bool fade = false;
    public Ease blinkease;
    
    void Start()
    {
        //blink.DOFade(0, 0);
        //blink.DOFade(0, 0).SetEase(blinkease).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    public void OnClickBlink()
    {
        blink.DOFade(2, 0).SetLoops(3,LoopType.Restart);    
    }
}
