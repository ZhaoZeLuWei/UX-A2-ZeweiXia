using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    public AudioSource backgroundMusic;
    private bool isMuted = false;
    private float volumeOn = 0.2f;
    private static AudioControl instance;

    void Awake()
    {
        // 确保AudioControl单例且不在场景切换时被销毁
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ToggleMute()
    {
        if (backgroundMusic == null) return;

        isMuted = !isMuted;
        backgroundMusic.volume = isMuted ? 0 : volumeOn;
    }
}
