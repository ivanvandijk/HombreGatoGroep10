﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ParadeKar : MonoBehaviour {

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    [Range(0.2f, 2)]
    private float _actionRadius;

    private float wayPointActionRadius;
    private Transform[] _wayPoints;
    private int currentWayPointIndex;
    private bool reachedEndOfPath;
    private Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Path path = GameObject.Find("Path").GetComponent<Path>();
        _wayPoints = path.GetWayPoints();
        currentWayPointIndex = 0;
        reachedEndOfPath = false;
        RotateToTarget();
    }

    void Update()
    {
        Debug.Log(reachedEndOfPath);
        if (!reachedEndOfPath)
        {
            movementSpeed = 2;
            float distance = Vector3.Distance(transform.position, _wayPoints[currentWayPointIndex].position);
            Debug.Log(currentWayPointIndex);
            if (distance <= _actionRadius)
            {
                if (currentWayPointIndex < _wayPoints.Length - 1)
                {
                    currentWayPointIndex++;
                    RotateToTarget();
                }
                else
                {
                    movementSpeed = 0;
                    reachedEndOfPath = true;
                    print("Reached End Of Path");
                }
            }
        }
        if (reachedEndOfPath == true && Input.GetKeyDown(KeyCode.Space))
        {
            currentWayPointIndex = 0;
            RotateToTarget();
            movementSpeed = 2;
            reachedEndOfPath = false;
        }
    }

    void FixedUpdate()
    {
        Vector3 Direction = transform.forward;
        Vector3 velocity = Direction * movementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + velocity);
    }

    void RotateToTarget()
    {
        transform.LookAt(_wayPoints[currentWayPointIndex].position);
    }
}