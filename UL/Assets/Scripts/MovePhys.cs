using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePhys : MonoBehaviour
{
    public float speed = 0.7f;
    public float jumpForce = 0.7f;
    public bool isGrounded;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddForce((transform.right * Input.GetAxis("Horizontal")) * speed / Time.deltaTime);
        rb.AddForce((transform.forward * Input.GetAxis("Vertical")) * speed / Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            Jump();
        }
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }
    public void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}