using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePlarformsTransition : Transition
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent(out Platform plarform))
        {
            plarform.Die();
            NeedTransit = true;
        }    
    }
}
