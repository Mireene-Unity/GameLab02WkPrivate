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
        SceondStart();
    }
    protected virtual void SceondStart(){ }
    /// <summary>
    /// ��ȣ�ۿ��� ���� ������ ���� �Լ� (true)�϶� �Լ� �۵�
    /// </summary>
    /// <returns></returns>
    protected virtual bool Condition()
    {
        return true;
    }
    /// <summary>
    /// ��ȣ�ۿ� �ൿ�ϴ� ���߾� �Լ�
    /// </summary>
    protected virtual void Interaction()
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
            if (IsContactPlayer())
            {
                //Debug.Log("IsContactPlayer");
                if (IsContactMouse())
                {
                    if (Condition())
                    {
                        Interaction();
                    }
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
