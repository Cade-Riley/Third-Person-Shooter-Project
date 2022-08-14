using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour
{
    [SerializeField] GameObject player;
    public virtual void OnHit()
    {
        Debug.Log("OnHit() is not overwritten!");
    }
}
