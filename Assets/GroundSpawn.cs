using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] grounds;

    void Update()
    {
        RaycastHit2D groundCheck = Physics2D.Raycast(transform.position, Vector2.down, 2);

        int groundNum = Random.Range(0, grounds.Length);        

        if (groundCheck.collider == null)
        {
            Instantiate(grounds[groundNum], transform.position + new Vector3(11.8f, 0, 0), Quaternion.identity);
        }
    }
}
