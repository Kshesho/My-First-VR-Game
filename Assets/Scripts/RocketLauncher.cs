using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    AudioSource _auSource;
    float _canFireTime;
    [SerializeField] float _cooldownTime = 1.6f;
    [SerializeField] GameObject _rocketPref;
    [SerializeField] Transform _launchPoint;

    private void Start()
    {
        _auSource = GetComponent<AudioSource>();
    }

    public void TriggerPull()
    {
        if (_canFireTime <= Time.time)
        {
            _canFireTime = Time.time + _cooldownTime;
            Instantiate(_rocketPref, _launchPoint.position, _launchPoint.rotation);
            _auSource.Play();
        }
    }
}
