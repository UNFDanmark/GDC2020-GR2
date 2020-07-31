using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour

   
{
    public float rotationSpeed = 10;

    public float forwardSpeed = -50;
    public float upSpeed = 7;
    public float range = 9;
    public Rigidbody Rigidbody;
    public Vector3 Direction;
    public Transform Player;
    public Transform Bus;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
        Bus = GameObject.Find("Bus").transform;
        Direction = new Vector3(0, Bus.position.y - Player.position.y, Bus.position.z - Player.position.z);
        Rigidbody.velocity = Direction.normalized * forwardSpeed + transform.up * upSpeed + new Vector3(Random.Range(-range, range), 0, 0) ;
        Destroy(gameObject,5); 
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, rotationSpeed); 
    }

  
   
}
