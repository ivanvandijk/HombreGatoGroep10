using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurning : MonoBehaviour
{

    [SerializeField]
    private float _turnSpeed;
    private Camera _camera;

    private void Start()
    {
        _camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float h = _turnSpeed * Input.GetAxis("Mouse X");
            _camera.transform.Rotate(0, -h, 0);

            float q = _turnSpeed * Input.GetAxis("Mouse Y");
            _camera.transform.Rotate(-q, 0, 0);
        }
    }
}
