using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArroundAxis : MonoBehaviour
{

    [SerializeField]
    private bool rotateX;

    [SerializeField]
    private bool rotateY;

    [SerializeField]
    private bool rotateZ;

    [SerializeField]
    private float rotationSpeed;

    
    void Update()
    {
        if(rotateX)
            this.transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0, Space.Self);

        if (rotateY)
            this.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);

        if (rotateZ)
            this.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
