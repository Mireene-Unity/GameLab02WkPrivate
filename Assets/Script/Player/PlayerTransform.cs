using UnityEngine;
public class PlayerTransform : MonoBehaviour
{
    float height;
    float width;
    float speed = 2.0f;
    int diraction;

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0) return;
        if (width == 0) height = Input.GetAxisRaw("Vertical");
        if (height == 0) width = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(width, height, 0) * speed * Time.deltaTime);
    }
    public int Diraction()
    {
        if (width > 0)
        {
            diraction = 1;
        }
        if (width < 0)
        {
            diraction = 2;
        }
        if (height > 0)
        {
            diraction = 3;
        }
        if (height < 0)
        {
            diraction = 4;
        }
        return diraction;
    }
}