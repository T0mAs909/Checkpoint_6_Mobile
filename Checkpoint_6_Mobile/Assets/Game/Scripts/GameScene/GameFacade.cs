using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFacade : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] UIManager uiManager;

    public static GameFacade instance;

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
    }

    public void StartGame()
    {
        audioManager.PlayAudio();
        uiManager.ShowUI();
    }
}