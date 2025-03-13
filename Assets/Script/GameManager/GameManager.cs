using UnityEngine;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Action<string> OnSignalSent;


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
    public void SendSignal()
    {
        string message = "isTimatosleep";
        OnSignalSent?.Invoke(message);
    }


    void OneDayCiycle()
    {
        // µ¿¹«
    }
}
