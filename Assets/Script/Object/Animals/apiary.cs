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
        sleep.Sleeping += Apiary.DayReset; // Action에 DayReset 구독
        sleep.Sleep(); // SleepingBed에서 Sleep 호출
    }
    protected override void Interaction()
    {
        isTodayWorking = true;
        Debug.Log("양봉통");
    }
    public static void DayReset() // public으로 유지
    {
        isTodayWorking = false; // static 필드 조작
        Debug.Log("Apiary DayReset");
    }
}



