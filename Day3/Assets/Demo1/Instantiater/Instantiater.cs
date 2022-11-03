using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiater : MonoBehaviour
{

    //private const float frequency = 1f;

    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateTargets());
    }

    IEnumerator InstantiateTargets()
    {
        //var yieldReturn = new WaitForSeconds(frequency);

        while (true)
        {

            var frequency = UnityEngine.Random.Range(0.5f, 1f);
            yield return new WaitForSeconds(frequency);

            //yield return yieldReturn;

            Debug.Log("Instantiate");

            Instantiate(Target, transform.position, Quaternion.identity );

            //TODO: Instantiate command
        }
    }
}
