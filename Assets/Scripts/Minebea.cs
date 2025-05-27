using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minebea : FirearmController
{
    bool _triggerHeld;
    float _canFireTime;
    [SerializeField] float _fireCooldown = 0.1f;

    private void Update()
    {
        if (_triggerHeld)
        {
            AutomaticFire();
        }
    }

    void AutomaticFire()
    {
        if (_canFireTime <= Time.time)
        {
            _canFireTime = Time.time + _fireCooldown;
            Fire();
        }
    }

    public override void TriggerPull()
    {
        _triggerHeld = true;
    }
    public void TriggerRelease()
    {
        _triggerHeld = false;
    }

}
