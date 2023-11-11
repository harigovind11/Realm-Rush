using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] private bool isPlaceable;

    void OnMouseDown()
    {
        if (isPlaceable)
        {
            Debug.Log(transform.name);
        }
    }
}