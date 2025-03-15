using UnityEngine;

public class Portal : Object_Interaction
{
    enum PortalNum { Farm = 1, House, HouseExit, Shop, ShopExit }

    [SerializeField]
    private PortalNum portalNum;

    private Vector3 destination;

    protected override void Interaction()
    {
        Teleport((int)portalNum);
        Debug.Log("Teleportation");
    }

    void Teleport(int portalNum)
    {
        switch ((PortalNum)portalNum)
        {
            case PortalNum.Farm:
                //destination = new Vector3(  ,   , 0);
                break;

            case PortalNum.House:
                destination = new Vector3( 0, 47, 0);
                break;

            case PortalNum.HouseExit:
                destination = new Vector3( 2, 1, 0);
                break;

            case PortalNum.Shop:
                //destination = new Vector3(  ,   , 0);
                break;

            case PortalNum.ShopExit:
                //destination = new Vector3(  ,   , 0);
                break;

            default:
                Debug.LogError("정의되지 않은 PortalNum 값입니다: " + portalNum);
                return;
        }

        Debug.Log("Teleport Transform");
        player.transform.position = destination;
    }
}