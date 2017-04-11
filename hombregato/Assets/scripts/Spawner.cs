using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform spawner;
    [SerializeField] private float movement;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 4);
    }
    void Spawn()
    {
        Instantiate(enemy, spawner.position, spawner.rotation);

    }
   
}