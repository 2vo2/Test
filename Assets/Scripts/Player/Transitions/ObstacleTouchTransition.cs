using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTouchTransition : Transition
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            NeedTransit = true;
        }    
    }
}