using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo1 : MonoBehaviour
{

    //first define variables
    public Button Btn_MyButton;

    //it works once
    private void Awake()
    {
        Btn_MyButton.onClick.AddListener(ButtonClick_MyButton);
    }

    public void ButtonClick_MyButton()
    {
        Debug.Log("ButtonClick_MyButton");
    }





    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */



}
