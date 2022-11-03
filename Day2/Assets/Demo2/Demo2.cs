using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Demo2 : MonoBehaviour
{
    private TextMeshProUGUI txtVariable;

    private void Awake()
    {
        txtVariable = GameObject.Find("TxtVariable").GetComponent<TextMeshProUGUI>();



        if (PlayerPrefs.HasKey("Variable"))
        {
            txtVariable.text = PlayerPrefs.GetString("Variable");
        }
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Variable"))
        {
            PlayerPrefs.SetString("Variable", "This is variable !!!");
        }
    }

}
