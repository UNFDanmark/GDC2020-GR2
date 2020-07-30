using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject CarObstaclePrefab;

    public float moveSpeed = 3;
    public float SpawnTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnTime <= 0)

        {
            Spawn();
            SpawnTime = 3;
        }

        SpawnTime -= Time.deltaTime;


        // If statement for when the obstacle should appear
    }
    public void Spawn()
    {
        GameObject newCarObstacle = Instantiate(CarObstaclePrefab);

        newCarObstacle.transform.position = transform.position;
        newCarObstacle.transform.rotation = transform.rotation;

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            print("You Won!");
        }
    }
}
