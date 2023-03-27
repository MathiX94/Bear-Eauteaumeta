using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private CharacterController characterController;
    private float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 movementDirection = new Vector3(horizontal, jump, vertical);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude);
        if (characterController.isGrounded)
        {
            ySpeed = -0.5f;
            if (Input.GetButtonDown("Jump"))
                ySpeed = jumpForce;
        }
        else
        {
            ySpeed += Physics.gravity.y * Time.deltaTime;
        }
        Vector3 finalDirection = movementDirection * speed * magnitude;
        finalDirection.y = ySpeed;
        characterController.Move(finalDirection * Time.deltaTime);
    }
}
