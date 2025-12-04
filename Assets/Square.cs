using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 180f; // градусов в секунду

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}

