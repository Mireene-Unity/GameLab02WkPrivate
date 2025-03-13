using System;
using UnityEngine;

public class SleepBed : Object_Interaction
{
    public override bool Condition()
    {
        return true;
    }
    public override void Interaction()
    {
        Debug.Log("Sleep");
        GameManager.Instance.SendSignal();
    }
}
