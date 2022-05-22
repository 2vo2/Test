using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingState : State
{
    [SerializeField] private GameObject _bridge;

    private void Update() 
    { 
        Animator.SetBool("Falling", true);
        _bridge.SetActive(false); 
    }
}
