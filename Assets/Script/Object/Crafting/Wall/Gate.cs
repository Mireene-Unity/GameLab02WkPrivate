using UnityEngine;

public class Gate : Object_Interaction
{
    public override bool Condition()
    {
        return true;
    }
    public override void Interaction()
    {
        Debug.Log("Gate");
    }
}
