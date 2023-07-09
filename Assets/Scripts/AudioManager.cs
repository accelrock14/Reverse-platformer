using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager bgInstance;

    public AudioSource bgMusic;

    private void Awake()
    {
        if (bgInstance != null && bgInstance != this)
        {
            Destroy(gameObject);
            return;
        }
        bgInstance = this;
        DontDestroyOnLoad(this);
    }
}
