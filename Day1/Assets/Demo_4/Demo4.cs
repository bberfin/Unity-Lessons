using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo4 : MonoBehaviour
{

    //most important monobehaviour methods

    private void Awake()
    {
        Debug.Log("Awake");      
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

}
