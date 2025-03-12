using UnityEngine;

public class Object_Interaction : MonoBehaviour
{
    Player_Find player_Find;
    GameObject player;
    Vector3 playerPosition;
    void Start()
    {
        player_Find = FindAnyObjectByType<Player_Find>();
        player = player_Find.gameObject;
        playerPosition = player.transform.position;
    }
    void Update()
    {
        if (player != null)
        {

        }
    }
}
