using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _diamondText;
    [SerializeField]private RawImage[] _carImage;
    private int _activeCarIndex=0;

    private void Start()
    {
        Car.OnGoldCollect += GoldCollect;
        Car.UI_System += ActiveCarImage;
    }

    private void GoldCollect(int diamondAmount) => _diamondText.text = diamondAmount.ToString();
    private void ActiveCarImage()
    {
        _carImage[_activeCarIndex++].enabled = true;
    }
}
