using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo3_2 : MonoBehaviour
{
    public GameObject CannonBall;

    public int fireForce;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBehaviour();
        }
    }

    public void ShootBehaviour()
    {
        Debug.Log("Shoot Behaviour");

        CannonBall.SetActive(true);

        var rgb = CannonBall.GetComponent<Rigidbody>();
        rgb.AddForce(CannonBall.transform.forward * fireForce);

    }
}
