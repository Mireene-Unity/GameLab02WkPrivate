using System;
using UnityEngine;

public class Apiary : Animal_Interaction
{
    protected override void AnimalMessage()
    {

    }
    protected override void SceondStart()
    {
        SleepingBed sleep = FindAnyObjectByType<SleepingBed>();
        if (sleep == null) { }
        sleep.Sleeping += Apiary.DayReset; // Action�� DayReset ����
        sleep.Sleep(); // SleepingBed���� Sleep ȣ��
    }
    protected override void Interaction()
    {
        isTodayWorking = true;
        Debug.Log("�����");
    }
    public static void DayReset() // public���� ����
    {
        isTodayWorking = false; // static �ʵ� ����
        Debug.Log("Apiary DayReset");
    }
}



