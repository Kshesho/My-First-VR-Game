using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : FirearmController
{
    [SerializeField] float _interShotCooldown = 0.3f;
    [SerializeField] float _reloadTime = 0.8f;
    float _canFireTime;
    int _loadedSlugs = 2;

    public override void TriggerPull()
    {
        if (_canFireTime <= Time.time)
        {
            //before firing, reload if all shots fired
            if (_loadedSlugs == 0)
            {
                _loadedSlugs = 2;
            }

            Fire();
            _loadedSlugs--;

            //after firing, trigger cooldown depending on shots remaining
            if (_loadedSlugs == 1)
            {
                _canFireTime = Time.time + _interShotCooldown;
            }
            else if (_loadedSlugs == 0)
            {
                _canFireTime = Time.time + _reloadTime;
            }
        }
    }

    protected override void PlayFireAudio()
    {
        _auSource.Play();
    }

}
