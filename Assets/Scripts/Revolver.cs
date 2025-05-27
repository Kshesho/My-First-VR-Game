using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : FirearmController
{
    public override void TriggerPull()
    {
        Fire();
    }
}

