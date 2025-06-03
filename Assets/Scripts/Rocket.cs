using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField] float _initialForce = 5;

    [SerializeField] GameObject _explosionPref;

    [SerializeField] float _explosionZSpawnOffset = -0.5f;
    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
                           //the rocket's forward is facing left
        _rigidBody.AddForce(transform.right * _initialForce, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + _explosionZSpawnOffset);
        Instantiate(_explosionPref, spawnPos, Quaternion.identity);
        Destroy(this.gameObject);
    }

}
