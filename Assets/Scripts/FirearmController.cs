using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class FirearmController : MonoBehaviour
{
    [SerializeField]
    protected GameObject _muzzleFlashPrefab, _hitPrefab;
    [SerializeField]
    protected Transform _rayOrigin;
    [SerializeField]
    protected Vector3 _muzzleFlashOffset;
    protected AudioSource _auSource;
    [SerializeField] 
    protected AudioClip _revolverAuClip;

    protected virtual void Start()
    {
        _auSource = GetComponent<AudioSource>();
    }

    public abstract void TriggerPull();

    protected void Fire()
    {
        Instantiate(_muzzleFlashPrefab, _rayOrigin.position + _muzzleFlashOffset, Quaternion.identity);

        _auSource.pitch = Random.Range(0.5f, 0.8f);
        _auSource.PlayOneShot(_revolverAuClip);

        if (Physics.Raycast(_rayOrigin.position, _rayOrigin.forward, out RaycastHit hit, Mathf.Infinity) && hit.transform.CompareTag("Target"))
        {
            Instantiate(_hitPrefab, hit.point, Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(_rayOrigin.position, _rayOrigin.forward * 10);
    }
}
