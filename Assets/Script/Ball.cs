using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 2.0f;

    private Vector3 direction;

    void Start()
    {
        direction = direction = new Vector3(0.5f, 0.5f, 0).normalized;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        var min = new Vector3(0, 0, Camera.main.nearClipPlane);
        var max = new Vector3(Screen.width, Screen.height, Camera.main.nearClipPlane);

        var screenMin = Camera.main.ScreenToWorldPoint(min);
        var screenMax = Camera.main.ScreenToWorldPoint(max);

        if (transform.position.x < screenMin.x || transform.position.x > screenMax.x)
        {
            direction.x = -direction.x;
        }
        if (transform.position.y < screenMin.y || transform.position.y > screenMax.y)
        {
            direction.y = -direction.y;
        }
    }
}
