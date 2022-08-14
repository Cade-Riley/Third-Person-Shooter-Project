using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    CharacterController characterController;

    [SerializeField] private float rotateSpeed;
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float range;
    [SerializeField] private ParticleSystem shotParticles;

    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Move();
        Shoot();
    }

    private void Move()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;
        characterController.Move(transform.TransformDirection(moveDirection) * Time.deltaTime);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * rotateSpeed);
    }

    private void Shoot()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
            {
                Instantiate(shotParticles, hit.point, Quaternion.identity);
                if (hit.transform.GetComponent<Target>())
                {
                    hit.transform.GetComponent<Target>().OnHit();
                }
            }
        }
    }
}
