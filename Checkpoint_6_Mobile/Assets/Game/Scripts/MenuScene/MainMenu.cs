using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    IMenuMediator mediator;
    [SerializeField] MenuMediator menuMediator;
    [SerializeField] GameObject settingsPanel;

    public void Awake()
    {
        menuMediator.InitializeMainMenu(this);
    }

    public void SetMediator(IMenuMediator mediator)
    {
        this.mediator = mediator;
    }

    public void OpenSettings()
    {
        mediator.Notify("OpenSettings");
    }

    public void Play()
    {
        mediator.Notify("Play");
    }

    public void ShowMenu()
    {
        settingsPanel.SetActive(true);
    }

    public void DoPlay()
    {
        SceneManager.LoadScene("GameScene");
    }
}