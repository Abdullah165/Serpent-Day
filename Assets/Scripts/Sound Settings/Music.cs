
using UnityEngine;

public class Music : MonoBehaviour
{
    static Music Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

    public void ToggleSound()
    {
        if(PlayerPrefs.GetInt("Muted",0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
    }

    public void ToggleVibration()
    {
        if (PlayerPrefs.GetInt("Vibrated", 0) == 0)
        {
            PlayerPrefs.SetInt("Vibrated", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Vibrated", 0);
        }
    }
}
