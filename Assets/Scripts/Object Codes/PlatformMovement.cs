using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector3 direction = Vector3.forward;
    public Vector3 startPosition;
    public Vector3 endPosition;

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + direction;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}