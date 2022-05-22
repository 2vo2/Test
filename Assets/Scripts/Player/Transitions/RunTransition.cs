using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTransition : Transition
{
    private void Update() 
    {
        NeedTransit = true;
    }
}
