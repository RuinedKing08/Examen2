using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject spawnRadius;


    void Update()
    {
        Vector3 moveDirection = Vector3.up * moveSpeed * Time.deltaTime;

        Camera.main.transform.Translate(moveDirection);

        transform.Translate(moveDirection);

        if (spawnRadius != null)
        {
            spawnRadius.transform.Translate(moveDirection);
        }
    }
}
