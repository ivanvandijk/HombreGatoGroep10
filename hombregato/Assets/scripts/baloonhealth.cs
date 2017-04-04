    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloonhealth : MonoBehaviour {
    [SerializeField]
    private GameObject objectToDestroy;


    void Update()
    {


    }
    void Start()
    {

    }
    void OnMouseDown()
    {
        Destroy(objectToDestroy);
    }
}
