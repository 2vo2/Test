using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunToFallingTransition : Transition
{
    [SerializeField] private GroundCheker _groundCheker;

    private void Update() 
    {
        if(_groundCheker.IsGrounded == false)
        {
            NeedTransit = true;
        }    
    }
}
