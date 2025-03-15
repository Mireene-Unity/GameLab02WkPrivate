using UnityEngine;
using System.Collections.Generic;

public class ObstacleChecker : MonoBehaviour
{
    private const float OBSTACLE_RADIUS = 0.6f; // ���簢�� ������ (0.5 ����)
    private const float CHECK_RADIUS_SQR = 4f; // ���� üũ ���� ���� (2 ����)

    private List<Vector2> obstaclePositions = new List<Vector2>();

    void Start()
    {
        InitializeObstacles();
    }

    void InitializeObstacles()
    {
        obstaclePositions.Clear();
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obstacle in obstacles)
        {
            Vector3 pos = obstacle.transform.position;
            obstaclePositions.Add(new Vector2(pos.x, pos.y));
        }
        Debug.Log($"�ʱ� ��ֹ� ����: {obstaclePositions.Count}");
    }

    public void AddObstacle(Vector2 newObstaclePosition)
    {
        obstaclePositions.Add(newObstaclePosition);
    }

    public bool CanMoveTo(Vector2 targetPosition)
    {
        Vector2 currentPosition = transform.position;
        for (int i = 0; i < obstaclePositions.Count; i++)
        {
            Vector2 obstaclePos = obstaclePositions[i];
            Vector2 diffToObstacle = obstaclePos - currentPosition;

            // ���� üũ (������ �������� ����, �ʿ� �� ���簢������ ���� ����)
            float distSqr = diffToObstacle.x * diffToObstacle.x + diffToObstacle.y * diffToObstacle.y;
            if (distSqr > CHECK_RADIUS_SQR)
            {
                continue;
            }

            // ���簢�� �浹 üũ
            Vector2 diffToTarget = targetPosition - obstaclePos;
            if (Mathf.Abs(diffToTarget.x) < OBSTACLE_RADIUS && Mathf.Abs(diffToTarget.y) < OBSTACLE_RADIUS)
            {
                return false; // ���簢�� ���� �� �浹
            }
        }
        return true;
    }
}