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
    /// ��ȣ�ۿ� ���� �߰� �ۿ�� �߻��� �̺�Ʈ
    /// </summary>
    void AnimalMessage()
    {

    }
}
