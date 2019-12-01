using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject MainMenuBehavior;
    public GameObject OptionsObject;
    public GameObject Main_Menu;

    public string music = "event:/mainMenu_music";
    FMOD.Studio.EventInstance musicEvent;

    public void Start()
    {
        musicEvent = FMODUnity.RuntimeManager.CreateInstance(music);
        musicEvent.start();
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
        GameIsPaused = false;
        musicEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
    public void Options()
    {
        Debug.Log("Enable: Options");
        OptionsObject.SetActive(true);
        Main_Menu.SetActive(false);
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI_button_press");
    }

    public void Back()
    {
        OptionsObject.SetActive(false);
        Main_Menu.SetActive(true);
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI_button_press");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }
}
