using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    private InputAction navigateAction;
    private InputAction submitAction;
    private NavigationContainer currentContainer => NavigationManger.Instance.currentContainer;
    // Update is called once per frame

    private void Awake()
    {
        navigateAction = InputSystem.actions.FindAction("Move");
        submitAction = InputSystem.actions.FindAction("Submit");

    }
    private void OnEnable()
    {
        navigateAction.performed += navigate;
        submitAction.performed += submit;
    }
    private void OnDisable()
    {
        navigateAction.performed -= navigate;
        submitAction.performed -= submit;
    }

    private void navigate(InputAction.CallbackContext context)
    {
        Vector2 value=  context.ReadValue<Vector2>();

        if(value.y > 0 ) 
        {
            currentContainer?.MovePrevious();
        }
        else
        {
            currentContainer?.MoveNext();
        }
    }

    private void submit(InputAction.CallbackContext context)
    {
        currentContainer?.Submit();
    }
}
