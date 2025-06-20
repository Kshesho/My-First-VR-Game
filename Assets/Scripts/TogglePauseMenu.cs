using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TogglePauseMenu : MonoBehaviour
{
    [SerializeField] InputActionReference _menuButtonAction;
    [SerializeField] GameObject _pauseMenu;
    bool _isMenuActive;

    void Update()
    {
        // Also use Escape key for toggling the menu
        if (Input.GetKeyDown(KeyCode.Escape))
            ToggleMenu();
    }

    private void OnEnable()
    {
        if (_menuButtonAction != null)
        {
            _menuButtonAction.action.Enable();
            _menuButtonAction.action.performed += _ => ToggleMenu();
        }
    }
    private void OnDisable()
    {
        if (_menuButtonAction != null)
        {
            _menuButtonAction.action.Disable();
            _menuButtonAction.action.performed -= _ => ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        _isMenuActive = !_isMenuActive;
        _pauseMenu.SetActive(_isMenuActive);
    }


}
