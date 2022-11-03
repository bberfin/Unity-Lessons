using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject Bullet;

    public Transform ReferencePositionOfBullet;

    public float Velocity;

    public void Throw()
    {
        Debug.Log("Throw");

        var bullet =  Instantiate(Bullet, ReferencePositionOfBullet.position, Quaternion.identity);
        var rgb = bullet.GetComponent<Rigidbody>();

        
        rgb.AddForce(-Vector3.forward * Velocity, ForceMode.Force);
        
    }

}
