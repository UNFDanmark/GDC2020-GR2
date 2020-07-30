using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCar : MonoBehaviour
{
    public Rigidbody Car;
    public float carSpeed = 3;
    public float destroytime = 3;
    public float CarZ;
    int TurnPosition = 0;

    public float forwardSpeed = -50;
    public float range = 9;
    public Vector3 Direction;
    public Transform Player;
    public bool Turned = false;
    // Start is called before the first frame update
    void Start()
    {
       TurnPosition = Random.Range(20, 30);

        Player = GameObject.Find("Player").transform;
        
        
        



       Destroy(gameObject, destroytime);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         CarZ = transform.position.z;
        if (Turned == true)
        {
            Car.velocity = Direction.normalized * forwardSpeed;

        }
        
        else if (CarZ <= TurnPosition)
        {
            Direction = new Vector3(transform.position.x - Player.position.x, 0, transform.position.z - Player.position.z);
            transform.forward = Direction;
            Car.velocity = Direction.normalized * forwardSpeed;
            Turned = true;
        } 

        
        else
        {
            Car.velocity = new Vector3(0, 0, -carSpeed);
        }


    }

}
