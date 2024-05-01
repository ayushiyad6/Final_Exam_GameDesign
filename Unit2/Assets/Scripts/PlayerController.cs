using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f ;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(projectilePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform. position. y, transform.position.z);
        }

        if (transform.position.x < -10) 
        {
            transform. position = new Vector3(-10, transform. position. y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            // Launch a projectile from the player
            Instantiate (projectilePrefab, transform.position, projectileprefab. transform.rotation);
        }

    }
}
