using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    private PlayerInputActions playerInputActions;

    public event EventHandler OnInterAction;

    private void Awake() {
        playerInputActions = new PlayerInputActions();
        // Here we are enabling the action map which is called as "Player"
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) {
        OnInterAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized() {

        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        return inputVector;
    }

}
