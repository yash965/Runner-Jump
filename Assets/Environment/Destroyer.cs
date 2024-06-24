using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] int destroyTime;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
}
