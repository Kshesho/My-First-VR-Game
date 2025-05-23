using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasketballNet : MonoBehaviour
{
    [SerializeField] BasketballHoop _hoop;
    Basketball _ball;

    private void Start()
    {
        if (_hoop == null)
            _hoop = transform.parent.GetComponent<BasketballHoop>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Basketball>(out _ball))
        {
            UIManager.Instance.AddBasketballScore(_ball.Points);
        }
    }
}
