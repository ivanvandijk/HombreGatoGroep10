using UnityEngine;
using System.Collections;

public class BaloonMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 1f;
    [SerializeField]
    private Rigidbody rb;
    [SerializeField] private GameObject objectToDestroy;
    void Start()
    {

    }

    void Update()
    {



        if (transform.position.y >= 450)     //hier destroy je de balon op possition 60
        {

            DestroyObject(gameObject);
        }

        Vector3 movement = new Vector3(0f, 4F, 0f);

        rb.velocity = movement * movementSpeed;
    }


 
}    

    
