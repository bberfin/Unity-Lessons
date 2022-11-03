using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Demo3 : MonoBehaviour
{
    private Button Btn_MyButton;

    private void Awake()
    {
        Btn_MyButton = GameObject.Find("MyButton").GetComponent<Button>();
        Btn_MyButton.onClick.AddListener(ButtonClick_MyButton);
    }

    public async void ButtonClick_MyButton()
    {
        Debug.Log("ButtonClick_MyButton");

        await Task.Delay(1000);

        StartCoroutine(ButtonClick_MyButton_IEnumerator());

    }

    IEnumerator ButtonClick_MyButton_IEnumerator()
    {
        
        Debug.Log("ButtonClick_phase1");

        yield return new WaitForSeconds(1);

        Debug.Log("ButtonClick_phase2");

    }

}
