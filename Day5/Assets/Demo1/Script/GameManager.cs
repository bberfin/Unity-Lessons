using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public SwerveMovement SwerveMovement;
    public SwerveInputSystem SwerveInputSystem;
    public PlayerMoverRunner PlayerMoverRunner;


    #region Singleton

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;

    }

    #endregion
}
