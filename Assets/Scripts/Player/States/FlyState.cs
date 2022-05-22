using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyState : State
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Backpack _backpack;
    [SerializeField] private float _flySpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private GameObject _bridge;

    private void OnEnable() 
    {
        _playerInput.DirectionChanged += OnDirectionChanged;
        
    }

    private void OnDisable() 
    {
        _playerInput.DirectionChanged -= OnDirectionChanged;
        
    }

    private void OnDirectionChanged(Vector2 direction)
    {
        Animator.SetBool("Flying", true);
        _bridge.SetActive(true);

        AddVelocity(0, _maxSpeed);
        int countPlatforms = _backpack.transform.childCount;

        if(direction.y > 0 && countPlatforms != 0)
        {
            AddVelocity(_flySpeed, _maxSpeed);
        }
        else
        {
            AddVelocity(-_flySpeed, _maxSpeed);
        }
        
    }

    private void AddVelocity(float flySpeed, float maxSpeed)
    {
        Rigidbody.velocity = new Vector3(0, flySpeed, maxSpeed);
    }
}
