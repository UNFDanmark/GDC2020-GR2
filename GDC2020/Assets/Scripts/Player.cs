using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public Rigidbody myRigidbody;

    public float moveSpeed = 3;
    public float moveForward = 3;
    public AudioSource audioSource;
    public AudioClip Drink;
    public AudioSource audioSourceCar;
    public AudioClip Hitcar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void FixedUpdate()
    { 
        Move(); 
    }
        

    public void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = new Vector3(-moveSpeed, 0, myRigidbody.velocity.z);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = new Vector3(moveSpeed, 0, myRigidbody.velocity.z);
        }
        else
        {
            myRigidbody.velocity = new Vector3(0, 0, myRigidbody.velocity.z);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Beer"))
        {

            audioSource.PlayOneShot(Drink);
            Destroy(col.gameObject);
            myRigidbody.velocity = new Vector3(0, 0, moveForward);
        }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {

            audioSource.PlayOneShot(Hitcar);

        }
    }


}

