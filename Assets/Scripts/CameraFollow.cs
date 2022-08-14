using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float verticalSpeed;

    void LateUpdate()
    {
        transform.position = player.transform.position + (player.transform.right * offset[0]) + (player.transform.up * offset[1]) + (player.transform.forward * offset[2]);
        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * verticalSpeed, 0, 0));
        //transform.rotation = Quaternion.Euler(Mathf.Clamp(transform.localEulerAngles.x, 40, 320), player.transform.localEulerAngles.y, player.transform.localEulerAngles.z);
        
        //Debug.Log(transform.eulerAngles.x);

        //Look down limit
        if(transform.localEulerAngles.x > 30 && transform.localEulerAngles.x < 200)
        {
            transform.localEulerAngles = new Vector3(30, player.transform.localEulerAngles.y, player.transform.localEulerAngles.z);
        }//look up limit
        else if (transform.localEulerAngles.x < 330 && transform.localEulerAngles.x > 100)
        {
            transform.localEulerAngles = new Vector3(330, player.transform.localEulerAngles.y, player.transform.localEulerAngles.z);
        }
        else
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, player.transform.localEulerAngles.y, player.transform.localEulerAngles.z);
        }
    }

}
