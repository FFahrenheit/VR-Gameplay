using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 30.0f;
    private float startDelay = 5.0f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        scoreText.SetText("Score: 0");
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        Invoke("DissapearIntro", startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     SpawnRandomAnimal();
        // }
    }

    void DissapearIntro()
    {
        GameObject intro = GameObject.Find("Intro");
        intro.SetActive(false);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
