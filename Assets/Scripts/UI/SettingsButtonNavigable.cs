using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButtonNavigable : ButtonNavigable
{
    [SerializeField] private Button toggleButton;
    bool isToggled = true;
    public override void OnPress()
    {
        if (isToggled)
        {
            toggleButton.OnDeselect(null);
            isToggled = false;
        }
        else
        {
            toggleButton.OnSelect(null);
            isToggled = true;
        }
    }

}
