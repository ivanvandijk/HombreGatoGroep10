using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  

public class SpinningGround : MonoBehaviour {
    [SerializeField]
    private float rotateSpeed = 100f;
    [SerializeField]
    private bool rotateX = false;

    [SerializeField]
    private bool rotateY = false;

    [SerializeField]
    private bool rotateZ = false;

    [SerializeField]
    private bool possitiveRotation = true;

    [SerializeField]
    private int posOrNeg = 1;



    void Start () {
		if(possitiveRotation == false)
        {

            posOrNeg = -1;
        }
	}
	
	void Update () {
        if (rotateX)
        {
            transform.Rotate(rotateSpeed * Time.deltaTime * posOrNeg, 0, 0);

        }
        if (rotateY)
        {

            transform.Rotate(0, rotateSpeed * Time.deltaTime * posOrNeg,0);

        }
        if (rotateZ)
        {

            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime * posOrNeg);
        }
	}
}
