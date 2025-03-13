using UnityEngine;

public class DropItem : Object_Interaction
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override bool Condition()
    {
        return true;
    }
    public override void Interaction()
    {
        Debug.Log("DropItem");
        Destroy(gameObject);
    }
}
