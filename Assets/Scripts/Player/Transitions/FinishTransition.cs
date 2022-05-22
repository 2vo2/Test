using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTransition : Transition
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent(out FinishPath finishPath))
        {
            NeedTransit = true;
        }    
    }
}
