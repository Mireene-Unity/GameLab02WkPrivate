using UnityEngine;

public class Apiary : Object_Interaction
{
    bool isTodayWorking = false;

    public override bool Condition()
    {
        if (isTodayWorking)
        {
            AnimalMessage();
            return false;
        }
        else return true;
    }
    public override void Interaction()
    {
        Debug.Log("Apiay");
        isTodayWorking = true;
    }
    void GiveMoney()
    {
        if (isTodayWorking)
        {

        }
    }
    /// <summary>
    /// 상호작용 이후 추가 작용시 발생할 이벤트
    /// </summary>
    void AnimalMessage()
    {

    }
}
