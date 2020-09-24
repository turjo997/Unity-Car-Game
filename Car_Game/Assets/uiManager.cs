using Packages.Rider.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    public Text ScoreText;

    public Button[] buttons;

    bool gameover;

    int Score;

    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
        Score = 0;
        InvokeRepeating("ScoreUpdate", 1.0f, 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "SCORE : " + Score;

       // Score += 1;
    }

    void ScoreUpdate() {
        if (gameover == false)
        {
            Score += 1;

        }
    }


    public void gameOverAction() {

        gameover = true;

        foreach (Button button in buttons)
        {
            button.gameObject.SetActive (true);
        }


        
    }


    public void Play()
    {

        SceneManager.LoadScene("level1");

       // Application.LoadLevel("level1");


    }

    public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }

    }

   
    public void MainMenu()
    {
        Application.LoadLevel("menuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }







}
