using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject CarObstaclePrefab;
    public GameObject HardCarPrefab;
    public Transform[] Spawnpoint;
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
            int Car = Random.Range(0, 2);
            if (Car == 0)
            {
                Spawn1();
            }
            else if (Car == 1)
            {
                Spawn2();
            }


            SpawnTime = 3;
        }

        SpawnTime -= Time.deltaTime;


        // If statement for when the obstacle should appear
    }
    public void Spawn1()
    {
        GameObject newCarObstacle = Instantiate(CarObstaclePrefab);
        int Position = Random.Range(0, 2);
        if (Position == 0)
        {
            newCarObstacle.transform.position = Spawnpoint[0].position;
            newCarObstacle.transform.rotation = Spawnpoint[0].rotation;
        }
        else if (Position == 1)
        {
            newCarObstacle.transform.position = Spawnpoint[1].position;
            newCarObstacle.transform.rotation = Spawnpoint[1].rotation;
        }

     

    }
    public void Spawn2()
    {
        GameObject newCarObstacle = Instantiate(HardCarPrefab);
        int Position = Random.Range(0, 2);
        if (Position == 0)
        {
            newCarObstacle.transform.position = Spawnpoint[0].position;
            newCarObstacle.transform.rotation = Spawnpoint[0].rotation;
        }
        else if (Position == 1)
        {
            newCarObstacle.transform.position = Spawnpoint[1].position;
            newCarObstacle.transform.rotation = Spawnpoint[1].rotation;
        }



    }


}
