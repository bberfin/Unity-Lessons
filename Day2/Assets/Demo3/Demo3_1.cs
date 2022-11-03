using UnityEngine;
using UnityEngine.SceneManagement;



// CONTROL + K + E

public class Demo3_1 : MonoBehaviour
{

    public void TransitionScene()
    {
        SceneManager.LoadScene("Scene3_2");
    }
}
