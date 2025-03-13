using System;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class Object_Interaction : MonoBehaviour
{
    Player_Find player_Find;
    GameObject player;
    Vector3 playerPosition;
    void Start()
    {
        player_Find = FindAnyObjectByType<Player_Find>();
        player = player_Find.gameObject;
    }
    void Update()
    {
        if (player == null) return;
        if (Input.GetMouseButton(1) == false) return;
        if (IsContactPlayer())
        if (IsContactMouse())
        {
            Debug.Log("Player Contact Object");
        }
    }
    bool IsContactPlayer()
    {
        playerPosition = player.transform.position;
        float distance = Vector3.Distance(playerPosition, transform.position);
        
        return distance <= 1.5;
    }
    bool IsContactMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        float distance = Vector3.Distance(mousePosition, transform.position);
        return distance <= 0.5;
    }
}
