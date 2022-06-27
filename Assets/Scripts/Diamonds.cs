using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamonds : MonoBehaviour
{
    [SerializeField] private GameObject[] _diamondPoints;
    [SerializeField] private GameObject _diamondPrefab;
    [SerializeField] private Transform _carParent;
    
    void Start()
    {
        int diamondCount = Random.Range(3, 7);
        for (int i = 0; i < diamondCount; i++)
        {
            int diamondPos = Random.Range(0, _diamondPoints.Length); 
            var diamond=Instantiate(_diamondPrefab, _diamondPoints[diamondPos].transform.position, Quaternion.Euler(-90,0,0));
            diamond.transform.SetParent(_carParent);
            
        }
        
    }

 
}
