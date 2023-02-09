using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseUI;
    public GameObject Player;
    public TMP_Text Contador;

    // Update is called once per frame
    void Start() {
        Player.SetActive(true);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(GameIsPaused) {
                Resume();
            } 
            else {
                Pause();
            }
        }
    }

    public void Resume() {
        //Player.SetActive(true);
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        //Player.SetActive(false);
        Contador.text = "x " + CollectingCoins.corsas;

        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame() {
        SceneManager.LoadScene("Playground");
    } 
    public void LoadMenu() {
        SceneManager.LoadScene("Menu");
    }
}
