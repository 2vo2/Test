using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsContainer : MonoBehaviour
{
    [SerializeField] private Platform[] _platforms;

    public Platform[] Platforms => _platforms;

    public void Die()
    {
        Destroy(gameObject);
    }
}
