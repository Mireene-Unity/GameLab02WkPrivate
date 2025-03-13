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
    }
    /// <summary>
    /// 상호작용을 위한 마지막 조건 함수 (true)일때 함수 작동
    /// </summary>
    /// <returns></returns>
    public virtual bool Condition()
    {
        return true;
    }
    /// <summary>
    /// 상호작용 행동하는 버추얼 함수
    /// </summary>
    public virtual void Interaction()
    {

    }
    void Update()
    {
        UpdateFunction();
    }
    void UpdateFunction()
    {
        if (player == null) return;
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("IsContactMouse");
            if (IsContactPlayer())
                Debug.Log("IsContactPlayer");
            if (IsContactMouse())
                {
                    if (Condition())
                    {
                        Interaction();
                    }
                }
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
