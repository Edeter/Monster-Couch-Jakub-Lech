using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{

    private InputAction exitAction;
    private NavigationContainer currentContainer => NavigationManger.Instance.currentContainer;
    // Update is called once per frame

    public Action<Vector2> Moved;

    [SerializeField] SceneLoad sceneLoad;
    private void Awake()
    {

        exitAction = InputSystem.actions.FindAction("Escape");

    }
    private void OnEnable()
    {

        exitAction.performed += OnEscape;
    }
    private void OnDisable()
    {

        exitAction.performed -= OnEscape;
    }



    private void OnEscape(InputAction.CallbackContext context)
    {
        sceneLoad.LoadMainMenu();
    }

}
