using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float width;
    private float height;
    public float speed = 5f;
    int diraction;

    private ObstacleChecker obstacleChecker;

    void Start()
    {
        obstacleChecker = GetComponent<ObstacleChecker>();
        if (obstacleChecker == null)
        {
            Debug.LogError("ObstacleChecker ");
        }
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0) return;

        if (width == 0) height = Input.GetAxisRaw("Vertical");
        if (height == 0) width = Input.GetAxisRaw("Horizontal");

        Vector2 movement = new Vector2(width, height) * speed * Time.deltaTime;
        Vector2 newPosition = (Vector2)transform.position + movement;

        if (obstacleChecker != null && obstacleChecker.CanMoveTo(newPosition))
        {
            transform.Translate(new Vector3(movement.x, movement.y, 0f)); // Vector2 -> Vector3 º¯È¯
        }
        else
        {
            width = 0;
            height = 0;
        }
    }
}