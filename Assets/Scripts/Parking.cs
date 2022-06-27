using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parking : MonoBehaviour
{
    [SerializeField] private GameObject ParkPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            ParkPoint.SetActive(true);
        }
        
    }
}
