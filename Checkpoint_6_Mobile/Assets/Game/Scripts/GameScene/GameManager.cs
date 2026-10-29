using UnityEngine;

public enum GameState
{
    Playing,
    Paused
}

public class GameManager : MonoBehaviour
{
    GameState state;

    void Start()
    {
        IsPlaying();
    }

    void Update()
    {
        PausePlay();
    }

    public void IsPlaying()
    {
        state = GameState.Playing;
        GameFacade.instance.StartGame();
    }

    public void PausePlay()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (state == GameState.Playing)
            {
                state = GameState.Paused;
                Time.timeScale = 0;
            }
            else if (state == GameState.Paused)
            {
                state = GameState.Playing;
                Time.timeScale = 1;
            }
        }
    }
}