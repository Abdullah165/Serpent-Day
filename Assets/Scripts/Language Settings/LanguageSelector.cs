using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LanguageSelector : MonoBehaviour
{
    private bool active = false;
    [SerializeField] Button[] LanguageList;

    [SerializeField] Sprite LanguageSelectedImage;
    [SerializeField] Sprite LanguageUnSelectedImage;

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
        PlayerPrefs.SetInt("LocalKey", index);
        LanguageList[index].GetComponent<Image>().sprite = LanguageSelectedImage;
        for (int i = 0; i < LanguageList.Length; i++)
        {
            if (i != index)
                LanguageList[i].GetComponent<Image>().sprite = LanguageUnSelectedImage;
        }
        active = false;
    }
}