using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    private bool _isGrounded = true;
    public bool IsGrounded => _isGrounded;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent(out Path path))
        {
            _isGrounded = true;
            //Debug.Log(_isGrounded);
        }   
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.TryGetComponent(out Path path))
        {
            _isGrounded = false;
            //Debug.Log(_isGrounded);
        }
    }
}
