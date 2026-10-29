using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioManager instance;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void PlayAudio()
    {
        audioSource.Play();
    }
}