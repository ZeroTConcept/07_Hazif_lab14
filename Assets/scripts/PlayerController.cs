﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float verticalinput = Input.GetAxis("Vertical");
        float horizontalinput = Input.GetAxis("Horizontal");



        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }


        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
