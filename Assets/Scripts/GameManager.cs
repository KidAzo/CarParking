using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
        
    }

    
    [SerializeField] private GameObject[] _myCars;
    [SerializeField] private int _levelCarCount;
    private int _currentCar = 0;
    private void OnEnable()
    {
        _instance = this;
    }
    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _myCars[_currentCar].GetComponent<Car>().Speed = 15;
            _myCars[_currentCar].GetComponent<Car>().Goable = true;
        }
    }

    public void NextCar()
    {
        if (_currentCar < _levelCarCount-1)
            _myCars[++_currentCar].SetActive(true);
        Debug.Log(_currentCar);
    }
}
