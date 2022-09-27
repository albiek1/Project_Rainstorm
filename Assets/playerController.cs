using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");
        gameObject.transform.position = new Vector3(transform.position.x + (xMove * speed*Time.deltaTime), 0.5f, transform.position.z + (zMove * speed*Time.deltaTime));
    }
}
