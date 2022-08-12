using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        transform.position = player.transform.position + (player.transform.right * offset[0]) + (player.transform.up * offset[1]) + (player.transform.forward * offset[2]);
        transform.rotation = player.transform.rotation;
    }
}
