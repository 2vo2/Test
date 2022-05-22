using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : State
{
    [SerializeField] private float _maxSpeed;

    private void Update() 
    {
        Animator.SetBool("Dying", false);
        Animator.SetBool("Falling", false);
        Animator.SetBool("Flying", false);   
        Animator.SetBool("Runing", true);
        Rigidbody.velocity = new Vector3(0, 0, _maxSpeed);    
    }
}
