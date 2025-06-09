using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeRoomManager : MonoBehaviour
{
    [SerializeField] GameObject _gazeInteractor;

    public void HatDonned()
    {
        _gazeInteractor.SetActive(true);
    }
    public void HatRemoved()
    {
        _gazeInteractor.SetActive(false);
    }

}
