using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }

    private void Update()
    {
        Hover();
        Rotate();
    }

    void Hover()
    {
        transform.position = Vector3.Lerp(startingPosition, startingPosition + new Vector3(0.0f, 0.1f, 0.0f), Mathf.PingPong(Time.time * 2, 1.0f));
    }

    void Rotate()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f));
    }
}
