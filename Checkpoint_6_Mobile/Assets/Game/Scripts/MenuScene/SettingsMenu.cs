using TMPro;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    IMenuMediator mediator;
    [SerializeField] MenuMediator menuMediator;
    [SerializeField] GameObject settingsPanel;
    [SerializeField] TMP_Text textTitle;

    public void Awake()
    {
        menuMediator.InitializeSettingsMenu(this);
    }

    public void SetMediator(IMenuMediator mediator)
    {
        this.mediator = mediator;
    }

    public void ColorRed()
    {
        mediator.Notify("ColorRed");
    }

    public void ColorBlue()
    {
        mediator.Notify("ColorBlue");
    }
    public void ColorYellow()
    {
        mediator.Notify("ColorYellow");
    }
    public void ColorGreen()
    {
        mediator.Notify("ColorGreen");
    }

    public void CloseSettings()
    {
        mediator.Notify("CloseSettings");
    }

    public void ChangeColorRed()
    {
        textTitle.color = Color.red;
    }

    public void ChangeColorBlue()
    {
        textTitle.color = Color.blue;
    }

    public void ChangeColorYellow()
    {
        textTitle.color = Color.yellow;
    }

    public void ChangeColorGreen()
    {
        textTitle.color = Color.green;
    }

    public void CloseMenu()
    {
        settingsPanel.SetActive(false);
    }
}