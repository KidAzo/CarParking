using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _effects;
    [SerializeField] private Transform _effectPosition;
    
    void Start()
    {
        Car.ParticleSystems += RunEffects;
    }


    private void RunEffects(string tag)
    {
        if(tag == "Wings")
            _effects[0].Stop();
        else if (tag == "Platform")
        {
            _effects[1].Play();
        }
            
        else if (tag == "Car")
        {
            _effects[2].Play();
        }
            
    }
 
}
