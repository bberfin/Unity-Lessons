using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private const float velocity = 70;

    private void FixedUpdate()
    {
        transform.position += new Vector3(0.1f, 0f, 0f)* Time.deltaTime * velocity;
    }
}
