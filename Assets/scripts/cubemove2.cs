using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove2 : MonoBehaviour
{
    private float speed;
    public Transform target;

    void Start()
    {
        speed = 0.01f;
        target.transform.position = new Vector3(10f, 0f, 0f);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
    }
}
