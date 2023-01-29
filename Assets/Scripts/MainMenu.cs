using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClick_Play() {
        SceneManager.LoadScene("PlayGround");
    }

    public void OnClick_Quit() {
        Debug.Log("SAIU");
        Application.Quit();
    }
}
