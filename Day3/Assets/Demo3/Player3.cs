using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        transform.DOMoveX(6f, 3f)
            .SetRelative(true)
            .SetEase(Ease.Linear)
            .SetSpeedBased(false)
            .SetLoops(-1, LoopType.Yoyo);

        transform.DORotate(Vector3.up * 360, 2f, RotateMode.FastBeyond360).onComplete = delegate
        {
            Debug.Log("Rotation completed !!");
        };
    }

    
}
