using UnityEngine;
using Ui;
public abstract class BasicNavigable : MonoBehaviour, INavigable
{
    public abstract void OnHover();

    public abstract void OnPress();

    public abstract void OnUnhover();
}
