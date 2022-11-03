using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Demo2 : MonoBehaviour
{
    public UnityEvent unityEvent;

    public void Run_UnityEvent()
    {
        Debug.Log("Run_UnityEvent");
    }

    public void ButtonClick_MyButton()
    {
        // question mark(?) -> null control
        unityEvent?.Invoke();
    }

}
