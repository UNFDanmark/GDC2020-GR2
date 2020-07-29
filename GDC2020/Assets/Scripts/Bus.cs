using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    public GameObject beerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

      // If statement for when the beer should be shot  
   
    }
    public void Shoot()
    {
        GameObject newBeer = Instantiate(beerPrefab);
        
        newBeer.transform.position = transform.position;
        newBeer.transform.rotation = transform.rotation;

    }
}
