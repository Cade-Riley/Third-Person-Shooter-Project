using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    CharacterController characterController;

    [SerializeField] private float rotateSpeed;
    [SerializeField] private float speed = 3.0f;

    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
        transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X"),0) * rotateSpeed);
    }

    private void Move()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;
        characterController.Move(transform.TransformDirection(moveDirection) * Time.deltaTime);
    }
}
