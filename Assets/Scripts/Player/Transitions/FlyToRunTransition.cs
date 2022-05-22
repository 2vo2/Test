using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyToRunTransition : Transition
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.TryGetComponent(out Path path))
        {
            NeedTransit = true;
        }
    }
}
