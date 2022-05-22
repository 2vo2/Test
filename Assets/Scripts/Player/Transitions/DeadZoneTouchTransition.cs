using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneTouchTransition : Transition
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent(out DeadZone deadZone))
        {
            NeedTransit = true;
        }
    }
}