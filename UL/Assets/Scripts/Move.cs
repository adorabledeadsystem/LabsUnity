using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    public float speed = 0.1f;
    public float jump = 2f;
    public bool isGrounded;
    private void Update()
      {
          if (Input.GetKey(KeyCode.D))
          {
              transform.position += new Vector3(speed, 0, 0);
          }
          else if (Input.GetKey(KeyCode.A))
          {
              transform.position += new Vector3(-speed, 0, 0);
          }
          else if (Input.GetKey(KeyCode.W))
          {
              transform.position += new Vector3(0, 0, speed);
          }
          else if (Input.GetKey(KeyCode.S))
          {
              transform.position += new Vector3(0, 0, -speed);
          }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            Jump();
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void Jump()
    {
        transform.position += new Vector3(0, jump, 0);
    }
    public void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
