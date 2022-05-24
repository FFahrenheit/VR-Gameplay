using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    public float zRange = 10.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        if(Input.touchCount > 0)
        {
            float phoneHorizontal = Input.GetTouch(0).deltaPosition.x;
            transform.Translate(Vector3.right * phoneHorizontal * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }

        if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        verticalInput = Input.GetAxis("Vertical");
        if(Input.touchCount > 0)
        {
            float phoneVertical = Input.GetTouch(0).deltaPosition.y;
            Debug.Log("Phone vertical " + phoneVertical);
            transform.Translate(Vector3.forward * phoneVertical * Time.deltaTime * speed);        
        }
        else
        {
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);        
        }        
        
        if(Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
