using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

public class ChangeSocketedScale : MonoBehaviour
{
    XRSocketInteractor _socketInteractor;
    [SerializeField] [Range(0.0001f, 1f)] float _reducedScale = 0.5f;
    Vector3 _originalScale = new Vector3();

    void Start()
    {
        _socketInteractor = GetComponent<XRSocketInteractor>();
    }

    public void ReduceScale()
    {
        var socketedObj = _socketInteractor.GetOldestInteractableSelected();
        if (socketedObj != null)
        {
            _originalScale = socketedObj.transform.localScale;
            socketedObj.transform.localScale = new Vector3(_reducedScale, _reducedScale, _reducedScale);
        }
    }

    public void RestoreScale(SelectExitEventArgs args)
    {
        var unsocketedObj = args.interactableObject;
        if (unsocketedObj != null)
        {
            unsocketedObj.transform.localScale = _originalScale;
        }
    }

}
