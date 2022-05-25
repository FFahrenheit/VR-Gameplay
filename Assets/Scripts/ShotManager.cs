using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotManager : MonoBehaviour
{
    public GameObject shotPrefab;
    private float startDelay = 5.0f;
    private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShotAtPosition", startDelay, spawnInterval);
    }

    void ShotAtPosition()
    {
        GameObject shooter = GameObject.Find("Main Camera");
        Instantiate(shotPrefab, shooter.transform.position, shooter.transform.rotation);
    }
}
