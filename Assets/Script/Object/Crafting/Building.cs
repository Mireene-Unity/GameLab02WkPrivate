using UnityEngine;

public class Building : MonoBehaviour
{
    void Start()
    {
        BuildingStart();
    }
    void Update()
    {
        FindBuildingPosition();
    }
    void BuildingStart()
    {

    }
    void FindBuildingPosition()
    {

    }
    void BuildingCancel()
    {

    }
    void BuildingEnded()
    {

    }

    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
}
