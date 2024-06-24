using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GroundMovement : MonoBehaviour
{
    private Rigidbody2D ground_rb;

    public float groundSpeed = 8;

    IncreaseGroundSpeed incSpeed;

    void Start()
    {
        ground_rb = GetComponent<Rigidbody2D>();
        incSpeed = GameObject.Find("GroundSpawnChecker").GetComponent<IncreaseGroundSpeed>();
    }

    void Update()
    {
        groundSpeed = incSpeed.groundSpeed;
    }

    void FixedUpdate()
    {
        ground_rb.velocity = new Vector2(-groundSpeed, ground_rb.velocity.y);
    }
}
