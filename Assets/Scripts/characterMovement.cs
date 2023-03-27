using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    public float speed;
    private CharacterController characterController;

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
        movementDirection *= speed;
        characterController.Move(movementDirection * Time.deltaTime);
        a
    }
}
