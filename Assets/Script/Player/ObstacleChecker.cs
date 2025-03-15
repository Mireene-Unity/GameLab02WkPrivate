using UnityEngine;
using System.Collections.Generic;

public class ObstacleChecker : MonoBehaviour
{
    private const float OBSTACLE_RADIUS = 0.6f; // 정사각형 반지름 (0.5 유닛)
    private const float CHECK_RADIUS_SQR = 4f; // 근접 체크 범위 제곱 (2 유닛)

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
        Debug.Log($"초기 장애물 개수: {obstaclePositions.Count}");
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

            // 근접 체크 (여전히 원형으로 유지, 필요 시 정사각형으로 변경 가능)
            float distSqr = diffToObstacle.x * diffToObstacle.x + diffToObstacle.y * diffToObstacle.y;
            if (distSqr > CHECK_RADIUS_SQR)
            {
                continue;
            }

            // 정사각형 충돌 체크
            Vector2 diffToTarget = targetPosition - obstaclePos;
            if (Mathf.Abs(diffToTarget.x) < OBSTACLE_RADIUS && Mathf.Abs(diffToTarget.y) < OBSTACLE_RADIUS)
            {
                return false; // 정사각형 범위 내 충돌
            }
        }
        return true;
    }
}