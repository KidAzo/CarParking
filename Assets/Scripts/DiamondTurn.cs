using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondTurn : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(new Vector3(0,0,.3f),Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Diamond"))
            gameObject.SetActive(false);
    }
}
