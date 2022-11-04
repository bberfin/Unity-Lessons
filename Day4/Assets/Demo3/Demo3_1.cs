using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo3_1 : MonoBehaviour
{

    public Rigidbody rgb1;
    public Rigidbody rgb2;

    public int force1;
    public int force2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rgb1.AddForce(Vector3.up * force1);            
            rgb2.AddForce(Vector3.up * force2);
        }
    }
}
