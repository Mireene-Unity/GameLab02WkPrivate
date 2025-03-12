using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    float upInput;
    float rightInput;
    float speed = 2.0f;
    Vector3 moveVector3;
    void Update()
    {
        MoveInput();
        VectorNomalized();
        transform.Translate(moveVector3 * speed * Time.deltaTime);
    }
    void MoveInput()
    {
        upInput = Input.GetAxis("Vertical"); // W(1) / S(-1)
        rightInput = Input.GetAxis("Horizontal"); // A(-1) / D(1)
    }
    void VectorNomalized()
    {
        moveVector3 = new Vector3(rightInput, upInput, 0).normalized;
    }
}