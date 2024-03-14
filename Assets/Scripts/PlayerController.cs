using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
   
    private float speed = 20f;

    public float xRange = 10f;
    public float zRange = 10f;
    public float zCenter = 10f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z <= zCenter-zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zCenter-zRange);
        }

        if (transform.position.z >= zCenter+zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zCenter+zRange);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, this.transform.position, projectilePrefab.transform.rotation);
        }
    }


}
