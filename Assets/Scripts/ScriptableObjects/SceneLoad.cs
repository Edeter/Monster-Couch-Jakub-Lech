using System;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneLoad", menuName = "Scriptable Objects/SceneLoad")]
public class SceneLoad : ScriptableObject
{
    public Action LoadMainMenuAction;
    public Action LoadGameAction;

    public void LoadMainMenu()
    {
        LoadMainMenuAction?.Invoke();
    }
    public void LoadGame()
    {
        LoadGameAction?.Invoke();
    }
}
