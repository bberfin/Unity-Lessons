using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverRunner : MonoBehaviour
{

    private bool canMotion = true;
    public bool CanMotion { get => canMotion; set => canMotion = value; }


    public float VelocityOfPlayer;

    private void FixedUpdate()
    {
        if (!canMotion)
        {
            return;
        }

        transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * VelocityOfPlayer ;            
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name =="FinalZone")
        {
            Debug.Log($"on trigger enter: {other.gameObject.name}");
            AccessEndPoint();
        }

    }

    public void AccessEndPoint()
    {
        canMotion = false;
    }
}
