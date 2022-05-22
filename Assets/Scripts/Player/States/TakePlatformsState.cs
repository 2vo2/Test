using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePlatformsState : State
{
    [SerializeField] private Backpack _backpack;
    [SerializeField] private Platform _platform;
    [SerializeField] private Transform _spawnPoint;

    private void Update() 
    {
        var newPlatform = Instantiate(_platform, _backpack.transform);

        newPlatform.transform.position = _spawnPoint.position;
        newPlatform.transform.parent = _backpack.transform;
        _spawnPoint.position += Vector3.up * newPlatform.transform.localScale.y; 
    }
}
