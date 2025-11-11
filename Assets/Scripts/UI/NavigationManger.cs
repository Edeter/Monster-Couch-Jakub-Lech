using NUnit.Framework;
using UnityEngine;
using Ui;
using System.Collections.Generic;

public class NavigationManger
{
    private Stack<NavigationContainer> containerStack = new();


    public NavigationContainer currentContainer => containerStack.Count > 0 ? containerStack?.Peek() : null;
    public static NavigationManger Instance
    {
        get
        {
            if(instance == null) instance = new NavigationManger();
            return instance;
        }
    }
    private static NavigationManger instance;

    public void JumpInto(NavigationContainer container)
    {
        if (currentContainer == container) return;

        currentContainer?.Desactivate();

        containerStack.Push(container);
        container.Activate();
    }

    public void Return()
    {
        if (containerStack.Count <= 0) return;

        NavigationContainer container = containerStack.Pop();
        container.Desactivate();
        currentContainer.Activate();
    }
}
