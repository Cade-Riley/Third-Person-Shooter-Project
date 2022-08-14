using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }

    public GameObject player;

    private void Awake()
    {
        Instance = this;
    }
}
