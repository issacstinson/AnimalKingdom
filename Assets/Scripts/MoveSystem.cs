using System.Collections;
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
        rbody = GetComponent<Rigidbody2D>();
        polygonCollider = GetComponent<PolygonCollider2D>();
        
    }

    void Awake()
    {

    }
    // Update is called once per frame

    void Update()
    {
        RaycastHit2D hit;
        Vector2 currentPos = rbody.position;
        if (Input.GetKey(KeyCode.D) == true)
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                Vector2 inputVector = new Vector2(2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed *2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
            
            }
            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                Vector2 inputVector = new Vector2(2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed * 2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
            }
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                Vector2 inputVector = new Vector2(-2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed * 2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
            }
            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                Vector2 inputVector = new Vector2(-2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed * 2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
            }
        }
        
        if (Input.GetKey(KeyCode.W) == true)
        {
            if (Input.GetKeyDown(KeyCode.D) == true)
            {
                Vector2 inputVector = new Vector2(2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed * 2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
            }
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                Vector2 inputVector = new Vector2(-2, 1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed * 2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
            }
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                Vector2 inputVector = new Vector2(-2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed * 2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
            }
            if (Input.GetKeyDown(KeyCode.D) == true)
            {
                Vector2 inputVector = new Vector2(2, -1);
                Vector2 movement = inputVector * movementSpeed;
                Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
                Vector2 sight = inputVector * movementSpeed * 2;
                Vector2 chkPos = currentPos + sight * Time.fixedDeltaTime;
                polygonCollider.enabled = false;
                hit = Physics2D.Raycast(newPos, chkPos, layerMask);
                polygonCollider.enabled = true;
                if (hit.transform.tag == "Path")
                {
                    rbody.MovePosition(newPos);
                }
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
