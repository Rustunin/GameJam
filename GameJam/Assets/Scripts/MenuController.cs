using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("Sound Settings")]
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultValue = 0.5f;
    [SerializeField] private GameObject ComfirmationPromt=null;
    [Header("Level to Load")]
    public string NewGameLeveltext;
    private string LeveltoLoad;
    [SerializeField]
    private GameObject noSavedGameDialog = null;
    private void Awake()
    {
        volumeSlider.value= PlayerPrefs.GetFloat("masterVolume");
        volumeTextValue.text = AudioListener.volume.ToString("0.0");
    }
    public void NewGameLoad()
    {
        SceneManager.LoadScene(NewGameLeveltext);
    }

    public void LoadGameDialogYes()
    {
        if(PlayerPrefs.HasKey("SavedLevel"))
        {
            LeveltoLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(LeveltoLoad);
        }
        else
        {
            noSavedGameDialog.SetActive(true);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextValue.text = AudioListener.volume.ToString("0.0");
    }
    public void ResetButton(string MenyType)
    {
        if (MenyType=="Audio")
        {
            AudioListener.volume = defaultValue;
            volumeSlider.value = defaultValue;
            volumeTextValue.text = defaultValue.ToString("0.0");
        }
    }
    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume",AudioListener.volume);
        StartCoroutine(ConfirmationBox());
        
    }

    public IEnumerator ConfirmationBox()
    {
        ComfirmationPromt.SetActive(true);
        yield return new WaitForSeconds(1);
        ComfirmationPromt.SetActive(false);
    }
}
