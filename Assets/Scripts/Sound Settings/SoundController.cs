using UnityEngine.UI;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private Music music;
    [SerializeField] Button musicToggleButton;
    [SerializeField] Button vibrationToggleButton;
    [SerializeField] Sprite soundOn;
    [SerializeField] Sprite soundOff;
    [SerializeField] Sprite vibrationOn;
    [SerializeField] Sprite vibrationOff;

    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindObjectOfType<Music>();
        UpdateSoundIcon();
        UpdateVibrationIcon();
    }

    public void PauseMusic()
    {
        music.ToggleSound();
        UpdateSoundIcon();
    }

    void UpdateSoundIcon()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            musicToggleButton.GetComponent<Image>().sprite = soundOn;
        }
        else
        {
            AudioListener.volume = 0;
            musicToggleButton.GetComponent<Image>().sprite = soundOff;
        }
    }

    public void PauseVibration()
    {
        music.ToggleVibration();
        UpdateVibrationIcon();
    }

    void UpdateVibrationIcon()
    {
        if (PlayerPrefs.GetInt("Vibrated", 0) == 0)
        {
            vibrationToggleButton.GetComponent<Image>().sprite = vibrationOn;
        }
        else
        {
            vibrationToggleButton.GetComponent<Image>().sprite = vibrationOff;
        }
    }
}
