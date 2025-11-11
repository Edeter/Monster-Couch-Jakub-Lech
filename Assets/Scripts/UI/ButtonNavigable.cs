using UnityEngine;
using UnityEngine.UI;

public class ButtonNavigable : BasicNavigable
{
    [SerializeField] private Button button;


    public override void OnHover()
    {
        button.OnSelect(null);
    }

    public override void OnPress()
    {
        button.onClick.Invoke();
    }

    public override void OnUnhover()
    {
        button.OnDeselect(null);
    }
}
