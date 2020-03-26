﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private PolygonCollider2D polygonCollider;
    public LayerMask layerMask;
    public float movementSpeed = 6.25f;
    Rigidbody2D rbody;

    private void Start()
    {
                
    }

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        polygonCollider = GetComponent<PolygonCollider2D>();
        RaycastHit2D hit;

        Vector2 start = transform.position;

        Vector2 end = start + new Vector2;
    }
    // Update is called once per frame

    void Update()
    {
        Vector2 currentPos = rbody.position;
        if (Input.GetKey(KeyCode.D) == true)
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                Vector2 inputVector = new Vector2(2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                Vector2 inputVector = new Vector2(2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                Vector2 inputVector = new Vector2(-2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                Vector2 inputVector = new Vector2(-2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            if (Input.GetKeyDown(KeyCode.D) == true)
            {
                Vector2 inputVector = new Vector2(2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                Vector2 inputVector = new Vector2(-2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                Vector2 inputVector = new Vector2(-2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
            if (Input.GetKeyDown(KeyCode.D) == true)
            {
                Vector2 inputVector = new Vector2(2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                rbody.MovePosition(newPos);
            }
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Wall")
        {
            
        }
    }
    */
}
