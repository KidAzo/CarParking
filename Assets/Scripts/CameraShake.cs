using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using Random = UnityEngine.Random;

public class CameraShake : MonoBehaviour
{
    

     
     public async UniTaskVoid Camera_Shake(float duration,float magnitude)
     {
          Vector3 originalPos = transform.localPosition;
          float elapsed = 0f;
          while (elapsed<duration)
          {
               float x = Random.Range(-1f,1f) * magnitude;
               float y = Random.Range(-1f, 1f) * magnitude;
               transform.localPosition = new Vector3(x, y, originalPos.z);
               elapsed += Time.deltaTime;
               await UniTask.Yield();
          }
          
          transform.localPosition = originalPos;
     }

   
    
     

}
