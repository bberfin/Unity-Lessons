using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Demo1 : MonoBehaviour
{

    public Cannon cannon;
    public TextMeshProUGUI Txt_score;

    public static Demo1 Instance;

    public float ScoreProperty
    {
        get{
            return PlayerPrefs.GetFloat("Score", 0f);
        }
        set{
            PlayerPrefs.SetFloat("Score", value);
            Txt_score.text = value.ToString();
        }
    }

    private void Start()
    {
        ScoreProperty = 0f;
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ThrowTheBullet();

            Debug.Log("Click the screen");


        }
    }

    private void ThrowTheBullet ()
    {
        Debug.Log("Throw the bullet");

        cannon.Throw();

    }

}
