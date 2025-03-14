using UnityEngine;

public class Gate : Object_Interaction
{
    protected override bool Condition()
    {
        return true;
    }
    protected override void Interaction()
    {
        Debug.Log("Gate");
    }
}
