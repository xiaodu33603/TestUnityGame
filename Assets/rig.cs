using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 p = body.position;
        p.x += moveX * speed * Time.deltaTime;
        p.y += moveY * speed * Time.deltaTime;
        body.MovePosition(p);
    }
}