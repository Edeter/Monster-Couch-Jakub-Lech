using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputAction moveAction;
    [SerializeField] Character playerCharacter;

    public Action<Vector2> PlayerMovedAction;

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }


    private void Update()
    {
       var moveVector=moveAction.ReadValue<Vector2>();
        OnMove(moveVector);
    }
    private void OnMove(Vector2 vector)
    {
        playerCharacter.Move(vector);
        PlayerMovedAction?.Invoke(vector);
    }
}
