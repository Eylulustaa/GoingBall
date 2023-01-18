using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    public float distance = 10f;

    void Update()
    {
        transform.position = target.position + (transform.position - target.position).normalized * distance;
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
    }
}