using System;
using UnityEngine;

public class SleepingBed : Object_Interaction
{
    public Action Sleeping;
    public void Sleep()
    {
        Sleeping?.Invoke();
    }
    protected override bool Condition()
    {
        return true;
    }
    protected override void Interaction()
    {
        Sleep();
        //Debug.Log("Sleep");
    }
}
