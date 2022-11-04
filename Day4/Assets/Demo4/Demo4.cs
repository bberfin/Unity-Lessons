using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo4 : MonoBehaviour
{

    public GameObject duckBody;
    public GameObject laserMachine;

    private int rotationSpeed = 45;
    private int laserLength = 25;

    public Material redMaterial;
    public Material defaultMaterial;

    Ray ray;
    RaycastHit hit;


    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rotateLaserMachine(0.1f);  
        }
        handleRaycast(laserMachine);
    }

    private void rotateLaserMachine(float axis)
    {
        laserMachine.transform.Rotate(0f, axis * rotationSpeed, 0, Space.World);
    }

    public void handleRaycast(GameObject handler)
    {
        Debug.DrawRay(handler.transform.position, handler.transform.TransformDirection(Vector3.forward*laserLength),Color.red);
        
        if(Physics.Raycast(handler.transform.position, handler.transform.TransformDirection(Vector3.forward * laserLength),out hit, laserLength))
        {
            if (hit.transform.gameObject.name == "Duck")
            {
                //this is time to colliding raycast with duck object
                duckBody.GetComponent<MeshRenderer>().material = redMaterial;
            }
        }

        else
        {
            duckBody.GetComponent<MeshRenderer>().material = defaultMaterial;
        }

    }
}
