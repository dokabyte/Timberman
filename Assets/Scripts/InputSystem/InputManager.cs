using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class InputManager
{
    public event Action OnHit;

    private GameControls gameControls;

    public InputManager()
    {
        gameControls = new(); // igual new GameControls()
        gameControls.Enable();
        gameControls.Player.Hit.performed += Hit;
    }

    private void Hit(InputAction.CallbackContext context)
    {
        OnHit?.Invoke();

        //Também pode ser escrito como:
        //if (OnHit == null)
        //{
        //    return;
        //}
        //else
        //{
        //    OnHit.Invoke();
        //}
    }
}
