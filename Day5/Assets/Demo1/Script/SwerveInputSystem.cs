using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    private float _lastFrameFingerPositionX;
    private float _moveFactoryX;

    public float MoveFactoryX { get => _moveFactoryX; }


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastFrameFingerPositionX = Input.mousePosition.x;

            Debug.Log("mouse tek t�k");
        }
        else if (Input.GetMouseButton(0))
        {

            Vector3 currentMousePosition = Input.mousePosition;

            _moveFactoryX = currentMousePosition.x = _lastFrameFingerPositionX;

            _lastFrameFingerPositionX = Input.mousePosition.x;

            Debug.Log("mouse bas�l� tutma");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _moveFactoryX = 0f; ;
            Debug.Log("mouse b�rakma");
        }
    }
}
