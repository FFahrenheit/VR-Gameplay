using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public void ShotAtPosition()
    {
        var shotOrigin = GameObject.Find("Player").transform.position;
        var shotDestination = transform.position;
        Vector3 trajectory = shotDestination - shotOrigin;
        var projectileRotation = Quaternion.LookRotation(trajectory);

        Debug.Log("Dest: " + shotDestination + "\tOrig: " + shotOrigin + "\tRotation: " + projectileRotation + "\tTraj: " + trajectory);
        Instantiate(projectilePrefab, shotOrigin, projectileRotation);
    }
}
