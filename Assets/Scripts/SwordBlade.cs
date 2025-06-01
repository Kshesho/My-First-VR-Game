using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBlade : MonoBehaviour
{
    [SerializeField] GameObject _particleEffectPref;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Target"))
        {
            Vector3 hitPos = other.ClosestPoint(transform.position);
            Instantiate(_particleEffectPref, hitPos, Quaternion.identity);
        }
    }

}
