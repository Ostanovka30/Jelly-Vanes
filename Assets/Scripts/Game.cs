using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Control Controls;
    public GameObject Player;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public CameraFollow Camera;
  

    private const string LevelIndexKey = "LevelIndex";
    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }


    private void Awake()
    {  
        Camera.PositionScreen();
        Controls.enabled = false; 
    }

    

    public async void StartGame()
    {
       
        await Task.Delay(1000);
        Player.gameObject.SetActive(true);
        Controls.enabled = true;
        Camera.PositionGame();
        StartScreen.gameObject.SetActive(false);
        PlayScreen.SetActive(true);
        
    }

    
    public async void OnPlayerDied()
    {
        Controls.enabled = false;
        await Task.Delay(1000);
        PlayScreen.SetActive(false);
        LoseScreen.SetActive(true);
        Camera.PositionScreen();
    }

    public async void OnPlayerReachFinish()
    {
        Controls.enabled = false;
        await Task.Delay(1000);
        PlayScreen.SetActive(false);
        WinScreen.SetActive(true);
        Camera.PositionScreen();
        LevelIndex++;
    }

   
    public async void ReloadLevel() // перезагрузка уровня
    {
        
        StartScreen.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        await Task.Delay(1000);
        Camera.PositionGame();
       
    }
}
