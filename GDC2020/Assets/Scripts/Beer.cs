using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour


{
    public float rotationSpeed = 10;

    public float forwardSpeed = -20;
    public float upSpeed = 4;
    public Rigidbody Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
       Rigidbody.velocity = transform.forward * forwardSpeed + transform.up * upSpeed;
        Destroy(gameObject,5);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed); 
    }

  
   
}
