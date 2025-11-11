using UnityEngine;

[CreateAssetMenu(fileName = "NavigateInGameEvent", menuName = "Scriptable Objects/NavigateInGameEvent")]
public class NavigationScriptableObject : ScriptableObject
{


    public void NavigateIn(NavigationContainer container)
    {
        NavigationManger.Instance.JumpInto(container);
    }
    public void NavigateOut()
    {
        NavigationManger.Instance.Return();
    }

    public void ExitGame()
    {
#if !UNITY_EDITOR
        Application.Quit();
#endif
    }
}
