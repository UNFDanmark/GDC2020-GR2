﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float PlayerMovement = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        { rb.AddForce(-PlayerMovement * Time.deltaTime, 0, 0); }

        else if (Input.GetKey("d"))
        { rb.AddForce(PlayerMovement * Time.deltaTime, 0, 0); }

       
    }
}
