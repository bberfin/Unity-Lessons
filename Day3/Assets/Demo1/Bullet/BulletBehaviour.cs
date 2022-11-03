using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{


    public ParticleSystem ExplodeEffect;

   private void OnCollisionEnter(Collision collision)
    {
        /*
        Debug.Log("OnCollisionEnter");

        if ( collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
        }
        */
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        if (other.gameObject.tag == "Target")
        {
            ExplodeEffect.transform.parent = null;
            ExplodeEffect.Play();

            //TODO: Update score and write on ui
            Demo1.Instance.ScoreProperty++;

            Destroy(other.gameObject);
        }


    }


}
