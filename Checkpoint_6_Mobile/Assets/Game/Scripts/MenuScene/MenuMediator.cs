using UnityEngine;

public class MenuMediator : MonoBehaviour, IMenuMediator
{
    MainMenu mainMenu;
    SettingsMenu settingsMenu;
    [SerializeField] GameObject settingsPanel;

    public void InitializeMainMenu(MainMenu mainMenuR)
    {
        mainMenu = mainMenuR;
    }
    
    public void InitializeSettingsMenu(SettingsMenu settingsMenuR)
    {
        settingsMenu = settingsMenuR;
    }

    void Start()
    {
        mainMenu.SetMediator(this);
        settingsMenu.SetMediator(this);
        settingsPanel.SetActive(false);
    }

    public void Notify(string eventName)
    {
        switch (eventName)
        {
            case "OpenSettings":
                mainMenu.ShowMenu();
                break;
            case "Play":
                mainMenu.DoPlay();
                break;
            case "ColorRed":
                settingsMenu.ChangeColorRed();
                break;
            case "ColorBlue":
                settingsMenu.ChangeColorBlue();
                break;
            case "ColorYellow":
                settingsMenu.ChangeColorYellow();
                break;
            case "ColorGreen":
                settingsMenu.ChangeColorGreen();
                break;
            case "CloseSettings":
                settingsMenu.CloseMenu();
                break;

        }
    }
}