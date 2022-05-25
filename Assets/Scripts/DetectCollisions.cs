using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource biteAudio;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        TextMeshProUGUI scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        scoreText.SetText("Score: " + ++CounterController.count);
        biteAudio.Play();
        Destroy(gameObject, 500);
        Destroy(other.gameObject);
    }
}
