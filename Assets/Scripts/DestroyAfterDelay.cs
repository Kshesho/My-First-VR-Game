using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    [SerializeField] float _timeBeforeDestroy = 5;

    void Start()
    {
        Destroy(this.gameObject, _timeBeforeDestroy);
    }
}
