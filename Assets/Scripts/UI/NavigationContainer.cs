using System.Collections.Generic;
using System.Linq;
using Ui;
using UnityEngine;

public class NavigationContainer : MonoBehaviour
{

    [SerializeField] private List<BasicNavigable> navigables = new();

    private int currentNavigableIndex = 0;
    public BasicNavigable CurrentNavigable => navigables.ElementAt(currentNavigableIndex);

    private void Awake()
    {
        NavigationManger.Instance.JumpInto(this);
    }
    public void Activate()
    {
        gameObject.SetActive(true);
        CurrentNavigable.OnHover();
    }
    public void Desactivate()
    {
        gameObject.SetActive(false);
        navigables.ForEach(navigable => navigable.OnUnhover());
    }

    public void MoveNext()
    {
        if (currentNavigableIndex < navigables.Count - 1)
        {
            CurrentNavigable.OnUnhover();
            currentNavigableIndex++;
            CurrentNavigable.OnHover();
        }
    }
    public void MovePrevious()
    {
        if (currentNavigableIndex > 0)
        {
            CurrentNavigable.OnUnhover();
            currentNavigableIndex--;
            CurrentNavigable.OnHover();
        }
    }

    public void Submit()
    {
        CurrentNavigable.OnPress();
    }
    public void Back()
    {

    }
}
