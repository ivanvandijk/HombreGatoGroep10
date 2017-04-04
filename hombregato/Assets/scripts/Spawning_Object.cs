using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_Object: MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn;

    private Vector3 spawnPosition;
    private float spawnDelay = 1f;
    private float speed = 0f;
    void Start()
    {
        spawnPosition = new Vector3(transform.position.x, speed, transform.position.z);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject e = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity) as GameObject;
        e.transform.SetParent(transform);
    }
}