using UnityEngine;

public class InputHandler : MonoBehaviour
{
    Player player;
    ICommand jumpCommand;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        jumpCommand = new JumpCommand(player);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpCommand.Execute();
        }
    }
}