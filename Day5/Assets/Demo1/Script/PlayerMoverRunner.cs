using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverRunner : MonoBehaviour
{

    private bool canMotion = true;
    public bool CanMotion { get => canMotion; set => canMotion = value; }


    public float VelocityOfPlayer;

    public GameObject Effect;

    private void FixedUpdate()
    {
        if (!canMotion)
        {
            return;
        }

        transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * VelocityOfPlayer;
        
       if(transform.position.x > 0.47f)
        {
            transform.position = new Vector3(0.47f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -0.47f)
        {
            transform.position = new Vector3(-0.47f, transform.position.y, transform.position.z);
        }

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
        float angle = 0;
        DOTween.To(() => VelocityOfPlayer, x => angle = x, 0, 1f)
            .OnUpdate(() =>
            {
                Debug.Log("DOTween Update");
            }).OnComplete(() => {
                Debug.Log("On Complete");
                canMotion = false;
                Effect.gameObject.SetActive(true);

                GameManager.Instance.ActivateWinUI();



            });

        
    }

    IEnumerator DecreaseSpeedOfPlayer()
    {
        var yieldReturn = new WaitForEndOfFrame();
        while (true)
        {

        }
    }

}
