using UnityEngine;

public class Animal_Interaction : Object_Interaction
{
    static protected bool isTodayWorking = false;
    protected override bool Condition()
    {
        if (isTodayWorking)
        {
            AnimalMessage();
            return false;
        }
        else return true;
    }
    /// <summary>
    /// 상호작용 이후 추가 작용시 발생할 이벤트
    /// </summary>
    protected virtual void AnimalMessage()
    {
    }
}