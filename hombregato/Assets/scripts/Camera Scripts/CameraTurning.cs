using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurning : MonoBehaviour {

    private int _boundary = 50;
    private float _speed = 1.5f;

    private int _theScreenWidth;
    private int _theScreenHeight;

    private Camera _camera;

    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    void Update() {
        if (Input.mousePosition.x > _theScreenWidth - _boundary)
        {
            _camera.transform.Rotate(Vector3.right, Time.deltaTime * _speed);
        }
        if (Input.mousePosition.x < 0 + _boundary)
        {
            _camera.transform.Rotate(Vector3.left, Time.deltaTime * _speed);
        }
        if (Input.mousePosition.y > _theScreenHeight - _boundary)
        {
            _camera.transform.Rotate(Vector3.down, Time.deltaTime * _speed);
        }
        if (Input.mousePosition.y < 0 + _boundary)
        {
            _camera.transform.Rotate(Vector3.up, Time.deltaTime * _speed);
        }
    }
}
