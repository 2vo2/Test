using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    [SerializeField] private GroundCheker _groundCheker;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _bridge;

    private void FixedUpdate() 
    {
        int platformCount = transform.childCount;

        if(_bridge.activeSelf == true)
        {
            StartCoroutine(DestroyPlatform(platformCount));
            Debug.Log(platformCount);
        }
        else
        {
            StopCoroutine(DestroyPlatform(platformCount));
        }
    }

    IEnumerator DestroyPlatform(int platformCount)
    {
        yield return new WaitForSeconds(1f);
        if(transform.childCount > 0)
        {
            Destroy(transform.GetChild(platformCount-1).gameObject);
            _spawnPoint.position -= Vector3.up * transform.GetChild(platformCount-1).transform.localScale.y;
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
