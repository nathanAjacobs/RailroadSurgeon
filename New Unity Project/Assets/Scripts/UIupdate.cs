using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIupdate : MonoBehaviour
{
    FMOD.Studio.Bus Music;
    FMOD.Studio.Bus SFX;
    FMOD.Studio.Bus Master;

    public Transform trainPosition;
    public Text scoreText;
    public Text gameOverText;
    public Text finalScore;
    private int score;
    public GameObject GameoverUI;

    private float timer;

    public static bool gameOver;

    public string music = "event:/background_music";
    FMOD.Studio.EventInstance musicEvent;

    // Start is called before the first frame update
    void Start()
    {
        score = (int)trainPosition.position.z;
        timer = 0f;
        gameOver = false;
        musicEvent = FMODUnity.RuntimeManager.CreateInstance(music);
        musicEvent.start();
        musicEvent.setPaused(false);
    }

    void Awake()
    {
        Music = FMODUnity.RuntimeManager.GetBus("bus:/Music");
        SFX = FMODUnity.RuntimeManager.GetBus("bus:/SFX");
        Master = FMODUnity.RuntimeManager.GetBus("bus:/Master");

        Music.setVolume(PlayerPrefs.GetFloat("MusicVolume"));

        SFX.setVolume(PlayerPrefs.GetFloat("SFXVolume"));


        Master.setVolume(PlayerPrefs.GetFloat("MasterVolume"));


    }

    // Update is called once per frame
    void Update()
    {
        //score = (int)trainPosition.position.z*10;
        scoreText.text = score.ToString();

        if(PauseMenu.GameIsPaused)
        {
            musicEvent.setPaused(true);
        }
        else
        {
            musicEvent.setPaused(false);
        }

        if(gameOver)
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0f;
            musicEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            GameoverUI.SetActive(true);

            finalScore.text = score.ToString();
        }
    }

    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer >= 1f/TrainMovement.speedOfTrain)
        {
            score += 10;
            timer = 0f;
        }
    }

    
}
