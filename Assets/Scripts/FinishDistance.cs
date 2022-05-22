using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishDistance : MonoBehaviour
{
    [SerializeField] private Transform _playerPosition;
    [SerializeField] private Transform _finishPoint;
    [SerializeField] private Slider _slider;

    private Vector3 _currentPlayerPosition;

    private void Update() 
    {
        _currentPlayerPosition = new Vector3(_playerPosition.position.x, _playerPosition.position.y, _playerPosition.position.z);
        _slider.maxValue = _finishPoint.position.z;
        _slider.value = _currentPlayerPosition.z;
    }
}
