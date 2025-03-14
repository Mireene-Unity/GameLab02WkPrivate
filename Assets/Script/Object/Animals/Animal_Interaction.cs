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
    /// ��ȣ�ۿ� ���� �߰� �ۿ�� �߻��� �̺�Ʈ
    /// </summary>
    protected virtual void AnimalMessage()
    {
    }
}