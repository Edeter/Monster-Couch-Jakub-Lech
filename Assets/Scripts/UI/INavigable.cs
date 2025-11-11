using UnityEngine;
using System;

namespace Ui
{
    public interface INavigable
    {
        public abstract void OnHover();
        public abstract void OnUnhover();
        public abstract void OnPress();
    }
}
