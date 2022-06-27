using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Car : MonoBehaviour
{
    private bool _firstGo=true;
    [Header("CarFeatures")]
    private float _speed=8f;
    private bool _goable;
    
    [SerializeField] private Transform _carParent;
    [SerializeField] private CameraShake _cameraShake;

    public static event Action<int> OnGoldCollect;
    public static event Action<string> Voices;
    public static event Action<string> ParticleSystems;
    public static event Action UI_System;
    [Header("DiamondCount")] 
    private int _diamondCount=0;
    public bool Goable
    {
        get
        {
            return _goable;
        }
        set
        {
            _goable = value;
        }
    }
    public float Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }

    private void Update()
    {
        if (Goable || _firstGo)
        {
            Go();
        }
        
    }
    
    public void Go() => transform.Translate((Speed * Time.deltaTime) * transform.forward);
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wings"))
        {
            Goable = false;
            transform.SetParent(_carParent);
            UI_System?.Invoke();
            ParticleSystems?.Invoke(other.tag);
            GameManager.Instance.NextCar();
        }
        
        else if (other.CompareTag("FirstPoint"))
        {
            _firstGo = false;
        }
        else if (other.CompareTag("Platform"))
        {
            Goable = false;
            _cameraShake.Camera_Shake(0.1f,0.3f).Forget();
            Voices?.Invoke(other.tag);
            ParticleSystems?.Invoke(other.tag);
        } 
        else if (other.CompareTag("Diamond"))
        {
            other.gameObject.SetActive(false);
            Voices?.Invoke(other.tag);
            _diamondCount++;
            OnGoldCollect?.Invoke(_diamondCount);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Voices?.Invoke(collision.gameObject.tag);
            ParticleSystems?.Invoke(collision.gameObject.tag);
            Debug.Log("CAR CRASH");
            //_cameraShake.Camera_Shake(0.1f,0.3f).Forget();
        }

    }
    


    
}
