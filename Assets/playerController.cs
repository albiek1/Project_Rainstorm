using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotSpeed = 10f;

    private CharacterController _controller;
    public Vector3 rotation;
    public float Gravity = -9.81f;
    public float GroundDistance = 0.2f;
    public Vector3 _velocity;
    public bool _isGrounded = true;
    private Transform _groundChecker;
    public LayerMask Ground;
    public float JumpHeight = 2f;
    public Vector3 Drag;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _groundChecker = transform.GetChild(0);
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
        if(_isGrounded && _velocity.y < 0)
        {
            _velocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = this.transform.TransformDirection(move);
        _controller.Move(move * Time.deltaTime * speed);
        this.transform.Rotate(this.rotation);

        if(Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velocity.y += Mathf.Sqrt(JumpHeight * -2f * Gravity);
        }

        _velocity.y += Gravity * Time.deltaTime;

        _velocity.x /= 1 + Drag.x * Time.deltaTime;
        _velocity.y /= 1 + Drag.y * Time.deltaTime;
        _velocity.z /= 1 + Drag.z * Time.deltaTime;

        _controller.Move(_velocity * Time.deltaTime);

        if (Input.GetKey("q"))
        {
            gameObject.transform.Rotate(0, -rotSpeed * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey("e"))
        {
            gameObject.transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.Self);
        }
    }
}
