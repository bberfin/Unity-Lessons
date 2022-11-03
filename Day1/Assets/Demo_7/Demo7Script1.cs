using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo7Script1 : MonoBehaviour
{

    public static Demo7Script1 Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void MainMethod()
    {
        Debug.Log("MainMethod");
    }
}
