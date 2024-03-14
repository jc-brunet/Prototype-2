using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float antiSpamInterval = 1f;
    public bool antiSpam=false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !antiSpam)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            antiSpam = true;
            Invoke("setAntiSpamFalse",antiSpamInterval);
        }
    }

    void setAntiSpamFalse()
    {
        antiSpam = false;
    }
}
