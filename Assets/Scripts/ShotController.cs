using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public void ShotAtPosition()
    {    
        var shotOrigin = GameObject.Find("CameraRig").transform.position;
        shotOrigin.y = 0.0f;
        var shotDestination = transform.position;
        Vector3 trajectory = shotDestination - shotOrigin;
        var projectileRotation = Quaternion.LookRotation(trajectory);
        Instantiate(projectilePrefab, shotOrigin, projectileRotation);
    }
}
