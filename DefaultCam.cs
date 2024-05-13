using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCam : MonoBehaviour
{
    public float rotationY; // user-defined rotation value for Y
    public float rotationX; // user-defined rotation value for X

    void Start()
    {
        // set main camera rotation to user-defined values
        Vector3 rotation = transform.rotation.eulerAngles;
        rotation.y = rotationY;
        rotation.x = rotationX;
        transform.rotation = Quaternion.Euler(rotation);
    }
}