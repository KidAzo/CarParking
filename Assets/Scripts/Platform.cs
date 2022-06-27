using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] 
    private float[] turnSpeeds;
    [SerializeField] 
    private GameObject[] platforms;
    
    void Update()
    {
        platforms[0].transform.Rotate(new Vector3(0,0,turnSpeeds[0]),Space.Self);
    }
}
