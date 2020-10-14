using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishMenu : MonoBehaviour
{
    public Button playAgainBtn, quitBtn;

    void Start(){
        playAgainBtn.onClick.AddListener(playAgain);
        quitBtn.onClick.AddListener(quit);
    }

    public void playAgain(){
        SceneManager.LoadScene(0);
    }

    public void quit(){
        Application.Quit();
    }
}
