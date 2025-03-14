using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEditor.PackageManager;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        // ½Ì±ÛÅæ ÆÐÅÏ ±¸Çö
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
 