using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseGroundSpeed : MonoBehaviour
{
    public float groundSpeed = 8;

    float groundSpeedCounter;

    [SerializeField] float increaseGroundSpeed = 0.01f;
    [SerializeField] int groundSpeedTimer = 1;

    void Start()
    {
        groundSpeedCounter = groundSpeedTimer;
    }

    void Update()
    {
        if (groundSpeedCounter <= 0)
        {
            groundSpeedCounter = groundSpeedTimer;
            if (groundSpeed <= 10)
            {
                groundSpeed += increaseGroundSpeed;
            }
        }
        else
        {
            groundSpeedCounter -= Time.deltaTime;
        }
    }
}
