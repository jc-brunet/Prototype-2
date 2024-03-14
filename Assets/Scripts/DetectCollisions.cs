using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject player;
    public GameObject foodPrefab;
    static private int lives = 3;
    static private int score = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {


        if (gameObject.name.StartsWith("D") && other.name.StartsWith("Player"))
        {
            Destroy(gameObject);
            DecrementLives();
        }

        if (gameObject.name.StartsWith("Dog") && other.name.StartsWith("Food"))
        {
            Destroy(other.gameObject);
            score = score + 1;
            Debug.Log("score = " + score);
            gameObject.GetComponent<AnimalHunger>().hungerSlider.value++ ;
            if (gameObject.GetComponent<AnimalHunger>().hungerSlider.value== gameObject.GetComponent<AnimalHunger>().amountToBeFed) { Destroy(gameObject);
                                                                                 }
        }


    }

    static public void DecrementLives()
    {
        lives--;
        if (lives > 0)
        {
            Debug.Log("Lives = " + lives);
        }
        else { Debug.Log("Game Over!"); }
    }

    static public int getLives()
    {
        return (lives);
    }
}
