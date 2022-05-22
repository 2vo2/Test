using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyToFallingTransition : Transition
{
    [SerializeField] private GroundCheker _groundCheker;
    [SerializeField] private Backpack _backpack;
    private void Update() 
    {
        if(Input.GetMouseButtonUp(0) || _backpack.transform.childCount == 0)
        {
            NeedTransit = true;
        }    
    }
}
