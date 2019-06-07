using UnityEngine;
using System.Collections;
public class Elevator : MonoBehaviour
{
    public float minHeight = 0.1f;
    public float maxHeight = 14f;
    public float velocity = 1;
    void Update()
    {
        float y = transform.position.y;
        y += velocity * Time.deltaTime;
        if (y > maxHeight)
        {
            y = maxHeight;
            velocity = -velocity;
        }
        if (y < minHeight)
        {
            y = minHeight;
            velocity = -velocity;
        }
        transform.position = new Vector3(transform.position.x, y,
        transform.position.z);
    }
}