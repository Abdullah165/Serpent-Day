using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LaguageManager : MonoBehaviour
{
    private bool active = false;
    private void Start()
    {
        int ID = PlayerPrefs.GetInt("LocalKey", 0);
        ChangeLanguage(ID);
    }

    public void ChangeLanguage(int index)
    {
        if (active)
            return;
        StartCoroutine(LocaleSelected(index));
    }

    IEnumerator LocaleSelected(int index)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
        active = false;
    }
}
