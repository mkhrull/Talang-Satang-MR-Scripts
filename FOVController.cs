// Unfortunately only works in Unity3D, whenever deployed into HoloLens, it defaults back to the original FOV

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVController : MonoBehaviour
{
    public float startFOV = 60f; // Initial FOV value
    public float targetFOV = 90f; // Target FOV value
  

    void Update()
    {
        Camera mainCamera = Camera.main; // Get the main camera
        mainCamera.fieldOfView = targetFOV;
    }
}
