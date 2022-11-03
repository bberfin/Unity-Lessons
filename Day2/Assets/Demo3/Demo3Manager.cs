using System.Collections;
using UnityEngine;

public class Demo3Manager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    private void Start()
    {
        StartCoroutine(DebugLogIENumerator());
    }


    IEnumerator DebugLogIENumerator()
    {

        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Demo3Manager");
        }
    }

}
