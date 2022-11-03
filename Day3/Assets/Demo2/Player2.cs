using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public Rigidbody rgb;

    public Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Slide(tr, Vector3.right);
    }

    public void Slide(Transform target, Vector3 railDirection)
    {
        Vector3 heading = target.position - transform.position;

        Vector3 force = Vector3.Project(heading, railDirection);

        rgb.AddForce(force);

    }
}
