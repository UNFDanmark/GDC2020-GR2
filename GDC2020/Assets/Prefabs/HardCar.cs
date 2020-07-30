using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody Car;
    public float carSpeed = 3;
    public float destroytime = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroytime);



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Car.velocity = new Vector3(0, 0, -carSpeed);

    }
}
