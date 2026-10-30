using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    UIManager instance;
    [SerializeField] TMP_Text textScore;
    [SerializeField] Canvas canvasUI;
    public Player player;

    void OnEnable()
    {
        player.OnAddScore += UpdateScore;
    }

    void OnDisable()
    {
        player.OnAddScore -= UpdateScore;
    }

    void Start()
    {
        textScore.text = "Score: 0";
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
    }

    public void UpdateScore(int score)
    {
        textScore.text = "Score: " + score;
    }

    public void ShowUI()
    {
        canvasUI.enabled = true;
    }
}