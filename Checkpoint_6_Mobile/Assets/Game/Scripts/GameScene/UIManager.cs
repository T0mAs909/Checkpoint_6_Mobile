using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    UIManager instance;
    public int score;
    [SerializeField] TMP_Text textScore;
    [SerializeField] Canvas canvasUI;

    void Start()
    {
        textScore.text = "Score: " + score;
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateScore()
    {
        score++;
        textScore.text = "Score: " + score;
    }

    public void ShowUI()
    {
        canvasUI.enabled = true;
    }

    public void ResetScore()
    {
        score = 0;
    }
}