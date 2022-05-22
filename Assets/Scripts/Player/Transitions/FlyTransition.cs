using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTransition : Transition
{
    [SerializeField] private Backpack _backpack;

    private void Update() 
    {
        if(Input.GetMouseButtonDown(0) && _backpack.transform.childCount != 0)
        {
            NeedTransit = true;
        }    
    }
}
