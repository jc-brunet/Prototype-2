using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 35f;
    private float lowerBound = -10f;
    private float leftBound = -25f;
    private float rightBound = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy objects that go out of bounds
        if (transform.position.z > topBound || transform.position.z < lowerBound || transform.position.x < leftBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
            if (gameObject.name.StartsWith("Dog"))
            {
                DetectCollisions.DecrementLives();
            }
        }


        
       
    }
}
