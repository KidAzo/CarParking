using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceManagement : MonoBehaviour
{
    [SerializeField] private AudioSource[] _voices;
    void Start()
    {
        Car.Voices += PlayVoices;
    }

    private void PlayVoices(string tag)
    {
        if(tag == "Diamond")
            _voices[0].Play();
        else if(tag =="Car" || tag== "Platform")
            _voices[1].Play();
    } 
   

}
