using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FoodEater : MonoBehaviour
{

    XRSocketInteractor _socketInteractor;

    private void Start()
    {
        _socketInteractor = GetComponent<XRSocketInteractor>();
    }

    public void EatFood()
    {
        var foodToEat = _socketInteractor.GetOldestInteractableSelected();
        Destroy(foodToEat.transform.gameObject);
    }
}
